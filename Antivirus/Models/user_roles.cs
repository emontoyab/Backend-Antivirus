using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

[PrimaryKey("users_id", "role_id")]
public partial class user_roles
{
    [Key]
    public long users_id { get; set; }

    [Key]
    public long role_id { get; set; }

    [MaxLength(1)]
    public char? trial755 { get; set; }

    [ForeignKey("role_id")]
    [InverseProperty("user_roles")]
    public virtual role role { get; set; } = null!;

    [ForeignKey("users_id")]
    [InverseProperty("user_roles")]
    public virtual users users { get; set; } = null!;
}
