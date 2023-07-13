using JobFinder.Models.Enums;

namespace JobFinder.Dtos.Job
{
    public class JobRequestDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public JobType JobType { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
    }
}
