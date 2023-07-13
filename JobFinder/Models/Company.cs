using JobFinder.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace JobFinder.Models
{
    public class Company:BaseModel
    {
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        public CompanySize Size { get; set; }

        // Relations
        public ICollection<Job> Jobs { get; set; }
    }
}
