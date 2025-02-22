namespace Antivirus.Dtos
{
    public class RoleDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
    }
    public class RoleCreateDto
    {
        public string? Name { get; set; }
    }
}