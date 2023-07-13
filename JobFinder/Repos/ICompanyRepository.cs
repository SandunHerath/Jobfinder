using JobFinder.Models;

namespace JobFinder.Repos
{
    public interface ICompanyRepository
    {
        public Task<Company> CreateCompany(Company company);
        public Task<List<Company>> GetAllCompanies();
        public Task<Company> GetById(long id);
    }
}
