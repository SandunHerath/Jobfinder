using JobFinder.Models;

namespace JobFinder.Repos
{
    public interface IJobRepository
    {
        public Task<Job> CreateJob(Job company);
        public Task<List<Job>> GetAllJobs();
        public Task<Job> GetById(long id);
    }
}
