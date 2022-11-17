using DVR.Infrastructure.Persistence;
using DVR.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace DVR.WebApi.Controllers
    {
        [Route("api/[controller]")]
        [Obsolete("Obsolete")]
        public class CompanyController : Controller
        {
            private readonly ICompanyRepository companyRepository;
            private readonly IDouVacancyResearcherService douVacancyResearcherService;
            private readonly IHostingEnvironment host;

            public CompanyController(IHostingEnvironment host,
                                    IDouVacancyResearcherService douVacancyResearcherService,
                                    ICompanyRepository companyRepository)
            {
                this.companyRepository = companyRepository;
                this.douVacancyResearcherService = douVacancyResearcherService;
                this.host = host;
            }
            
            [HttpGet("[action]")]
            public IActionResult Get()
            {
                douVacancyResearcherService.RootPath = host.WebRootPath;
                var companies = companyRepository.GetCompanies().Where(c => c.Vacancies.Any());
            
                return Ok(companies);
            }

            // [HttpGet("[action]")]
            // public IActionResult GetJson()
            // {
            //     var companiesJsonPath = FileLocation.GetJsonPath(host.WebRootPath);
            //     var stream = new FileStream(companiesJsonPath, FileMode.Open, FileAccess.Read);
            //     return Ok(stream);
            // }

            [HttpPost("[action]")]
            public async Task<IActionResult> Update()
            {
                douVacancyResearcherService.RootPath = host.WebRootPath ?? "";
                await douVacancyResearcherService.UpdateCompanyRepository();
                return Ok("Companies are updated");
            }
        }
    }