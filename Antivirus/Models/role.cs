using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class role
{
    [Key]
    public long id { get; set; }

    [StringLength(255)]
    public string? name { get; set; }

    [MaxLength(1)]
    public char? trial755 { get; set; }

    [InverseProperty("role")]
    public virtual ICollection<user_roles> user_roles { get; set; } = new List<user_roles>();
}
