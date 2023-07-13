using JobFinder.Models;

namespace JobFinder.Repos
{
    public interface ICandidateRepository
    {
        public Task<Candidate> CreateCandidate(Candidate candidate, IFormFile pdfFile);
        public Task<List<Candidate>> GetAllCandidate();
        public Task<Candidate> GetById(long id);
       // public Task DownloadPdf(string url);
    }
}
