using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class users
{
    [Key]
    public long id { get; set; }

    [StringLength(255)]
    public string? date_birth { get; set; }

    [StringLength(255)]
    public string? email { get; set; }

    [StringLength(255)]
    public string? last_name { get; set; }

    [StringLength(255)]
    public string? name { get; set; }

    [StringLength(255)]
    public string? password { get; set; }

    [MaxLength(1)]
    public char? trial755 { get; set; }

    [InverseProperty("id_userNavigation")]
    public virtual ICollection<user_oportunities> user_oportunities { get; set; } = new List<user_oportunities>();

    [InverseProperty("users")]
    public virtual ICollection<user_roles> user_roles { get; set; } = new List<user_roles>();

    [InverseProperty("id_usuarioNavigation")]
    public virtual ICollection<users_bootcamps> users_bootcamps { get; set; } = new List<users_bootcamps>();
}
