using JobFinder.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace JobFinder.Models
{
    public class Job : BaseModel
    {
        [Required]
        [MaxLength(80)]
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public string Description { get; set; }
        public JobType JobType { get; set; }

        // Relations
        public long CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
    }
}
