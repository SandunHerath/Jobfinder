using System.ComponentModel.DataAnnotations;

namespace JobFinder.Models
{
    public class Candidate: BaseModel
    {
        [Required]
        [MaxLength(80)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(80)]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public string CoverLetter { get; set; }
        [Required]
        public string ResumeUrl { get; set; }

        // Relations

        public long JobId { get; set; }
        public Job Job { get; set; }
    }
}
