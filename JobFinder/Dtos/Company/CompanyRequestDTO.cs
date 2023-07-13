using JobFinder.Models.Enums;

namespace JobFinder.Dtos.Company
{
    public class CompanyRequestDTO
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }
    }
}
