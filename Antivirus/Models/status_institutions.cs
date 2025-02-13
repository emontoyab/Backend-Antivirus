using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class status_institutions
{
    [Key]
    public long id { get; set; }

    [StringLength(255)]
    public string? status_review { get; set; }

    [MaxLength(1)]
    public char? trial751 { get; set; }

    [InverseProperty("id_statusNavigation")]
    public virtual ICollection<institutions> institutions { get; set; } = new List<institutions>();
}
