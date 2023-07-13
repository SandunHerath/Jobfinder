using AutoMapper;
using JobFinder.Dtos.Candidate;
using JobFinder.Dtos.Company;
using JobFinder.Models;
using JobFinder.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IMapper _mapper;

        public CandidateController(ICandidateRepository candidateRepository, IMapper mapper)
        {
            _candidateRepository = candidateRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandidateResponseDTO>>> GetAllCandidates()
        {
            var candidates = await _candidateRepository.GetAllCandidate();
            var mappedCandidate = _mapper.Map<ICollection<CandidateResponseDTO>>(candidates);
            if (candidates == null)
            {
                return NotFound();
            }
            return Ok(mappedCandidate);
        }
        // Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCandidate([FromForm] CandidateRequestDTO dto, IFormFile pdfFile)
        {
            // Firt => Save pdf to Server
            // Then => save url into our entity
            var fiveMegaByte = 5 * 1024 * 1024;
            var pdfMimeType = "application/pdf";

            if (pdfFile.Length > fiveMegaByte || pdfFile.ContentType != pdfMimeType)
            {
                return BadRequest("File is not valid");
            }
            Candidate newCandidate = _mapper.Map<Candidate>(dto);
            await _candidateRepository.CreateCandidate(newCandidate, pdfFile);
            return Ok("Candidate Created Successfully");
        }

        // Read (Download Pdf File)
        [HttpGet]
        [Route("download/{url}")]
        public async Task<IActionResult>DownloadPdf(string url)
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
    }
}

