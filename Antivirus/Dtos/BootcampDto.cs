namespace Antivirus.Models.DTOs
{
    public class BootcampDto
    {
        public long Id { get; set; }
        public string Nombre { get; set; } = null!;
        public long? IdCostosId { get; set; }
        public long? IdEstadoId { get; set; }
        public long? IdGeneralId { get; set; }
        public long? IdTemasId { get; set; }
        public string? Informacion { get; set; }
        public char? Trial751 { get; set; }
    }
}