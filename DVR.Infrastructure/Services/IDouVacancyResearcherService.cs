namespace DVR.Infrastructure.Services
{
    public interface IDouVacancyResearcherService
    {
         string RootPath { get; set; }
         Task UpdateCompanyRepository();
    }
}