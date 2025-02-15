namespace Antivirus.DTOs
{
    public class DescriptionsBootcampsDTO
    {
        public long id { get; set; }
        public string? description { get; set; }
    }

    public class DescriptionsBootcampsCreateDto
    {
        public string? description { get; set; }
    }
}
