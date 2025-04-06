namespace Antivirus.Dtos
{
    public class ServiceDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? image_url { get; set; }
    }

    public class ServiceCreateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? image_url { get; set; }
    }
}