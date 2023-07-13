using AutoMapper;
using JobFinder.Dtos.Job;
using JobFinder.Models;
using JobFinder.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/jobs")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public JobController(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobResponseDTO>>> GetAllCompanies()
        {
            var jobs = await _jobRepository.GetAllJobs();
            var mappedJobs = _mapper.Map<ICollection<JobResponseDTO>>(jobs);
            if (jobs == null)
            {
                return NotFound();
            }
            return Ok(mappedJobs);
        }
        // Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateJob([FromBody] JobRequestDTO dto)
        {
            Job newJob = _mapper.Map<Job>(dto);
            await _jobRepository.CreateJob(newJob);
            return Ok("Companty Created Successfully");
        }

        // Read (Get Company By ID)
        [HttpGet("{id}")]
        public async Task<ActionResult<JobResponseDTO>> GetSingleJob(long id)
        {
            var job = await _jobRepository.GetById(id);
            var mapped_job = _mapper.Map<JobResponseDTO>(job);
            if (job == null)
            {
                return NotFound();
            }
            return Ok(mapped_job);
        }
    }
}
