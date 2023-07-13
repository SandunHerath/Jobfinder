using AutoMapper;
using JobFinder.Dtos.Candidate;
using JobFinder.Dtos.Company;
using JobFinder.Dtos.Job;
using JobFinder.Models;

namespace JobFinder.Helper
{
    public class AutoMapperProfilConfiguration:Profile
    {
        public AutoMapperProfilConfiguration() {
            //Company
            CreateMap<CompanyRequestDTO, Company>();
            CreateMap<Company, CompanyResponseDTO>();

            // Job
            CreateMap<JobRequestDTO, Job>();
            CreateMap<Job, JobResponseDTO>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name));

            // Candidate
            CreateMap<CandidateRequestDTO, Candidate>();
            CreateMap<Candidate, CandidateResponseDTO>()
                .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.Job.Title));

        }
    }
}
