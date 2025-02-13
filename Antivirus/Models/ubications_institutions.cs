using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class ubications_institutions
{
    [Key]
    public long id { get; set; }

    [StringLength(144)]
    public string? zona { get; set; }

    [MaxLength(1)]
    public char? trial751 { get; set; }

    [InverseProperty("ubications_institutionsNavigation")]
    public virtual ICollection<institutions> institutions { get; set; } = new List<institutions>();
}
