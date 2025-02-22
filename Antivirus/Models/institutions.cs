using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Antivirus.Models;

public partial class institutions
{
    [Key]
    public long id { get; set; }

    [StringLength(255)]
    public string? bienestar_link { get; set; }

    [StringLength(255)]
    public string? carer_link { get; set; }

    [StringLength(255)]
    public string? directions { get; set; }

    [StringLength(255)]
    public string? general_link { get; set; }

    [StringLength(255)]
    public string? procces_link { get; set; }

    public long? id_status { get; set; }

    public long? ubications_institutions { get; set; }

    [StringLength(255)]
    public string? name { get; set; }

    [StringLength(255)]
    public string? observations { get; set; }

    [MaxLength(1)]
    public char? trial751 { get; set; }

    [ForeignKey("id_status")]
    [InverseProperty("institutions")]
    public virtual status_institutions? id_statusNavigation { get; set; }

    [InverseProperty("id_institutionsNavigation")]
    public virtual ICollection<institute_bootcamps> institute_bootcamps { get; set; } = new List<institute_bootcamps>();

    [InverseProperty("id_institutionsNavigation")]
    public virtual ICollection<institute_opportunities> institute_opportunities { get; set; } = new List<institute_opportunities>();

    [ForeignKey("ubications_institutions")]
    [InverseProperty("institutions")]
    public virtual ubications_institutions? ubications_institutionsNavigation { get; set; }
}
