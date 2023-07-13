using JobFinder.Models.Enums;

namespace JobFinder.Dtos.Company
{
    public class CompanyResponseDTO
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public CompanySize Size { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
