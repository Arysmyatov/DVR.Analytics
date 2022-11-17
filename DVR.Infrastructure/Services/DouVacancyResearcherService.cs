using DVR.Contracts.Entities;
using DVR.Infrastructure.Constants;
using DVR.Infrastructure.Persistence;
using DVR.Models;
using HtmlAgilityPack;

namespace DVR.Infrastructure.Services
{
    public class DouVacancyResearcherService : IDouVacancyResearcherService
    {
        #region private fields

        private readonly ICompanyRepository companyRepository;
        private readonly ITechnologyCountAnalysisResultRepository technologyCountAnalysisResultRepository;   

        private TechnologyCountAnalysisResult technologyCountAnalysisResult;

        #endregion private fields

        public string RootPath { get; set; }

        #region constructors

        public DouVacancyResearcherService(ICompanyRepository companyRepository,
                                          ITechnologyCountAnalysisResultRepository technologyCountAnalysisResultRepository)
        {
            this.companyRepository = companyRepository;
            this.technologyCountAnalysisResultRepository = technologyCountAnalysisResultRepository;

            InitTechnologyCountAnalysisResult();
        }

        #endregion constructors        


        #region public methods

        public async Task UpdateCompanyRepository(){
            var companies = await GetCompaniesAsync();
            companyRepository.UpdateCompanies(companies);
            technologyCountAnalysisResultRepository.AddResult(technologyCountAnalysisResult);
        }


        private async Task<IEnumerable<Company>> GetCompaniesAsync()
        {
            var urls = await GetUrlsAsync();
            var companies = new Dictionary<string, Company>();

            foreach (var url in urls)
            {
                var htmlDoc = await GetVacancyContentAsync(url);

                var pageContent = GetPageContent(htmlDoc);

                if (string.IsNullOrEmpty(pageContent.CompanyName))
                {
                    continue;
                }

                if (!companies.ContainsKey(pageContent.CompanyName))
                {
                    companies.Add(pageContent.CompanyName, new Company
                    {
                        Name = pageContent.CompanyName,
                        Vacancies = new List<Vacancy>()
                    });
                }

                var currentCompany = companies[pageContent.CompanyName];
                var tags = GetTags(pageContent);
                if(!tags.Any()){
                    continue;
                }

                currentCompany.Vacancies.Add(new Vacancy
                {
                    Url = url,
                    PositionName = pageContent.PositionDescription.ToUpper(),
                    Tags = tags
                });
            }

            return companies.Values;
        }

        #endregion public methods        


        #region private methods


        private PageContent GetPageContent(HtmlDocument htmlDocument)
        {
            return new PageContent
            {
                CompanyName = GetCompanyName(htmlDocument),
                CompanyDescription = GetCompanyDescription(htmlDocument),
                Vacancy = GetVacancy(htmlDocument).ToUpper(),
                AboutProject = GetAboutProject(htmlDocument),
                PositionDescription = GetPositionDescription(htmlDocument)
            };
        }


        private async Task<string> ReadFileAsync()
        {
            var filePath = FileLocation.GetPath(RootPath);

            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            var allText = string.Empty;
            using (StreamReader reader = new StreamReader(fileStream))
            {
                allText = await reader.ReadToEndAsync();
            }

            return allText;
        }

        private async Task<IEnumerable<string>> GetUrlsAsync()
        {
            var fileContent = await ReadFileAsync();

            var htmlDoc = new HtmlDocument();
            var content = fileContent;
            htmlDoc.LoadHtml(content);

            return htmlDoc.DocumentNode.SelectNodes(XPaths.VacancyUrl)
                                       .Select(u => u.Attributes["href"].Value);
        }


        private string GetCompanyName(HtmlDocument htmlDoc)
        {
            var nodes = htmlDoc.DocumentNode.SelectNodes(XPaths.CompanyName);
            if (nodes == null)
            {
                return string.Empty;
            }
            var node = nodes.FirstOrDefault();
            if (node == null)
            {
                return string.Empty;
            }

            return node.InnerHtml;
        }


        private string GetCompanyDescription(HtmlDocument htmlDoc)
        {
            var nodes = htmlDoc.DocumentNode.SelectNodes(XPaths.CompanyDescription);
            if (nodes == null)
            {
                return string.Empty;
            }
            var node = nodes.FirstOrDefault();
            if (node == null)
            {
                return string.Empty;
            }

            return node.InnerHtml;
        }


        private string GetVacancy(HtmlDocument htmlDoc)
        {
            var nodes = htmlDoc.DocumentNode.SelectNodes(XPaths.Vacancy);
            if (nodes == null)
            {
                return string.Empty;
            }
            var node = nodes.FirstOrDefault();
            if (node == null)
            {
                return string.Empty;
            }

            return node.InnerHtml;
        }



        private string GetAboutProject(HtmlDocument htmlDoc)
        {
            var nodes = htmlDoc.DocumentNode.SelectNodes(XPaths.AboutProject);
            if (nodes == null)
            {
                return string.Empty;
            }
            var node = nodes.FirstOrDefault();
            if (node == null)
            {
                return string.Empty;
            }

            return node.InnerHtml;
        }

        private string GetPositionDescription(HtmlDocument htmlDoc)
        {
            var nodes = htmlDoc.DocumentNode.SelectNodes(XPaths.Position);
            if (nodes == null)
            {
                return string.Empty;
            }
            var node = nodes.FirstOrDefault();
            if (node == null)
            {
                return string.Empty;
            }

            return node.InnerHtml;
        }


        private async Task<HtmlDocument> GetVacancyContentAsync(string url)
        {
            var httpClient = new HttpClient();

            var parameters = new Dictionary<string, string>();

            var response = await httpClient.PostAsync(url, new FormUrlEncodedContent(parameters));
            var content = await response.Content.ReadAsStringAsync();

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(content);

            return htmlDoc;
        }


        private IEnumerable<string> GetTags(PageContent pageContent)
        {
            var tags = new List<string>();
            foreach(var tagGroup in technologyCountAnalysisResult.TagGroups){
                foreach (var tagDescription in tagGroup.TagDescriptions)
                {
                    foreach (var technology in tagDescription.Technologies)
                    {
                        if (pageContent.Vacancy
                                    .Contains(technology.ToUpper()))
                        {
                            tagDescription.Count++;
                            tags.Add(tagDescription.Name);
                            break;
                        }
                    }
                }    
            }

            return tags;
        }


        private void InitTechnologyCountAnalysisResult()
        {
            technologyCountAnalysisResult = new TechnologyCountAnalysisResult {
                Date = DateTime.Now,
                TagGroups = TagGroups.GetAllTagGroups()
            };
        }

        #endregion private methods        
    }
}