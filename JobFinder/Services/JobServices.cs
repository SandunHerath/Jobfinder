using JobFinder.Context;
using JobFinder.Models;
using JobFinder.Repos;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Services
{
    public class JobServices : IJobRepository
    {
        private readonly AppDBContext _context = new AppDBContext();
        public async Task<Job> CreateJob(Job job)
        {
            await _context.Jobs.AddAsync(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task<List<Job>> GetAllJobs()
        {
            var jobs = await _context.Jobs.Include(job => job.Company).OrderByDescending(q => q.CreatedAt).ToListAsync();
            return (jobs);
        }

        public async Task<Job> GetById(long id)
        {
            var job = await _context.Jobs.FindAsync(id);
            return (job);
        }
    }
}
