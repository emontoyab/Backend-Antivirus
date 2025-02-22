namespace Antivirus.DTOs
{
    public class UserOpportunitiesResponseDto
    {
        public long id { get; set; }
        public long? id_opportunity { get; set; }
        public long? id_user { get; set; }
    }

    public class UserOpportunitiesRequestDto
    {
        public long? id_opportunity { get; set; }
        public long? id_user { get; set; }
    }
}
