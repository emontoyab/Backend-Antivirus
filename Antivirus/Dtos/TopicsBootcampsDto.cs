namespace Antivirus.DTOs
{
    public class TopicsBootcampsResponseDto
    {
        public long id { get; set; }
        public string? topics { get; set; }
    }

    public class TopicsBootcampsRequestDto
    {
        public string? topics { get; set; }
    }
}
