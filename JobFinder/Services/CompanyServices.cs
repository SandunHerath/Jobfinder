using JobFinder.Context;
using JobFinder.Models;
using JobFinder.Repos;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Services
{
    public class CompanyServices : ICompanyRepository
    {
        private readonly AppDBContext _context = new AppDBContext();

        public async Task<Company> CreateCompany(Company company)
        {
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
            return company;

        }

        public async Task<List<Company>> GetAllCompanies()
        {
            var companies = await _context.Companies.OrderByDescending(q => q.CreatedAt).ToListAsync();
            return(companies);
        }

        public async Task<Company> GetById(long id)
        {
            var company=await _context.Companies.FindAsync(id);
            return (company);
        }
    }
}
