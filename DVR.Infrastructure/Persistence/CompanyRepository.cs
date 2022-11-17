using DVR.Infrastructure.Services;
using DVR.Models;

namespace DVR.Infrastructure.Persistence
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly XmlContext context;
        private IEnumerable<Company> companies;

        public CompanyRepository(XmlContext context){
            this.context = context;
            companies = this.context.Companies;
        }
        
        public IEnumerable<Company> GetCompanies()
        {
            return companies;
        }

        public void UpdateCompanies(IEnumerable<Company> companies)
        {
            this.companies = companies;
            context.Companies = companies;
            context.UpdateComapnies();
        }
    }
}