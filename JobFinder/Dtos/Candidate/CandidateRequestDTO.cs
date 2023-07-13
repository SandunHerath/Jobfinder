namespace JobFinder.Dtos.Candidate
{
    public class CandidateRequestDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CoverLetter { get; set; }
        public long JobId { get; set; }
    }
}
