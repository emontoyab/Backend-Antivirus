using System.Text.Json.Serialization;

namespace Antivirus.Dtos
{
    public class BenefitDTO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? image_url { get; set; }
    }

    public class BenefitCreateDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? image_url { get; set; }
    }
}