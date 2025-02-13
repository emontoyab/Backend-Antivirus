using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class costs_bootcamps
{
    [Key]
    public long id { get; set; }

    [StringLength(255)]
    public string? costs { get; set; }

    [MaxLength(1)]
    public char? trial751 { get; set; }

    [InverseProperty("id_costos")]
    public virtual ICollection<bootcamps> bootcamps { get; set; } = new List<bootcamps>();
}
