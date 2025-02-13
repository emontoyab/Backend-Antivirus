using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class type_opportunities
{
    [Key]
    public long id { get; set; }

    [StringLength(255)]
    public string? oportunity_type { get; set; }

    [MaxLength(1)]
    public char? trial755 { get; set; }

    [InverseProperty("oportunity_typeNavigation")]
    public virtual ICollection<opportunities> opportunities { get; set; } = new List<opportunities>();
}
