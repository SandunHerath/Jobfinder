using AutoMapper;
using JobFinder.Dtos.Company;
using JobFinder.Models;
using JobFinder.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Controllers
{
    [Route("api/company")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyController(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyResponseDTO>>> GetAllCompanies() { 
        var companies=await _companyRepository.GetAllCompanies();
            var mappedCompanies = _mapper.Map<ICollection<CompanyResponseDTO>>(companies);
            if (companies == null)
            {
                return NotFound();
            }
            return Ok(mappedCompanies);
        }
        // Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyRequestDTO dto)
        {
            Company newCompany = _mapper.Map<Company>(dto);
            await _companyRepository.CreateCompany(newCompany);
            return Ok("Companty Created Successfully");
        }

        // Read (Get Company By ID)
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyResponseDTO>> GetSingleCompany(long id)
        {
            var company = await _companyRepository.GetById(id);
            var mapped_company = _mapper.Map<CompanyResponseDTO>(company);
            if (company == null)
            {
                return NotFound();
            }
            return Ok(mapped_company);
        }

    }
}
