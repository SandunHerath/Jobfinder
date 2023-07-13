using JobFinder.Models.Enums;

namespace JobFinder.Dtos.Job
{
    public class JobResponseDTO
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public JobType JobType { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
