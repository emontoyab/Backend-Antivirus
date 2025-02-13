using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class categories_opportunities
{
    [Key]
    public long id { get; set; }

    [StringLength(255)]
    public string? categories { get; set; }

    [MaxLength(1)]
    public char? trial751 { get; set; }

    [InverseProperty("id_categoriesNavigation")]
    public virtual ICollection<opportunities> opportunities { get; set; } = new List<opportunities>();
}
