using DVR.Models;

namespace DVR.Infrastructure.Persistence
{
    public interface ICompanyRepository
    {
         void UpdateCompanies(IEnumerable<Company> companies);
         IEnumerable<Company> GetCompanies();
    }
}