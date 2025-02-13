using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class status_bootcamps
{
    [Key]
    public long id { get; set; }

    [StringLength(255)]
    public string? status { get; set; }

    [MaxLength(1)]
    public char? trial751 { get; set; }

    [InverseProperty("id_estado")]
    public virtual ICollection<bootcamps> bootcamps { get; set; } = new List<bootcamps>();
}
