namespace Antivirus.Dtos
{
    public class InstituteBootcampsDto
    {
        public long id { get; set; }
        public long? id_bootcamps { get; set; }
        public long? id_institutions { get; set; }
        public char? trial755 { get; set; }
    }

    public class InstituteBootcampsCreatedDto
    {
        public long? id_bootcamps { get; set; }
        public long? id_institutions { get; set; }
        public char? trial755 { get; set; }
    }
}
