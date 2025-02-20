namespace Antivirus.Dtos
{
    public class UsersBootcampsDto
    {
        public long id { get; set; }
        public long? id_bootcamp { get; set; }
        public long? id_usuario { get; set; }
    }

    public class UsersBootcampsCreatedDto
    {
        public long? id_bootcamp { get; set; }
        public long? id_usuario { get; set; }
    }
}
