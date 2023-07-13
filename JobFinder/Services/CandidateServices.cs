using AutoMapper;
using JobFinder.Context;
using JobFinder.Models;
using JobFinder.Repos;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Services
{
    public class CandidateServices : ICandidateRepository
    {
        private readonly AppDBContext _context = new AppDBContext();
        public async Task<Candidate> CreateCandidate(Candidate candidate, IFormFile pdfFile)
        {
            var resumeUrl = Guid.NewGuid().ToString() + ".pdf";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "documents", "pdfs", resumeUrl);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await pdfFile.CopyToAsync(stream);
            }
            candidate.ResumeUrl = resumeUrl;
            await _context.Candidates.AddAsync(candidate);
            await _context.SaveChangesAsync();

                return candidate;
        }

/*        public Task DownloadPdf(string url)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "documents", "pdfs", url);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("File Not Found");
            }

            var pdfBytes = System.IO.File.ReadAllBytes(filePath);
            var file = File(pdfBytes, "application/pdf", url);
            return file;
        }
*/
        private object File(byte[] pdfBytes, string v, string url)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Candidate>> GetAllCandidate()
        {
            var candidate = await _context.Candidates.OrderByDescending(q => q.CreatedAt).ToListAsync();
            return (candidate);
        }

        public async Task<Candidate> GetById(long id)
        {
            var candidate = await _context.Candidates.FindAsync(id);
            return (candidate);
        }
    }
}
