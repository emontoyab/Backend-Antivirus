namespace Antivirus.Dtos
{
    public class InstitutionOpportunitiesDto
    {
        public long id { get; set; }
        public long? id_institutions { get; set; }
        public long? id_opportunities { get; set; }

    }

    public class InstitutionOpportunitiesCreatedDto
    {
        public long? id_institutions { get; set; }
        public long? id_opportunities { get; set; }

    }
}
