using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

[Table("users bootcamps")]
public partial class users_bootcamps
{
    [Key]
    public long id { get; set; }

    public long? id_bootcamp { get; set; }

    public long? id_usuario { get; set; }

    [MaxLength(1)]
    public char? trial755 { get; set; }

    [ForeignKey("id_bootcamp")]
    [InverseProperty("users_bootcamps")]
    public virtual bootcamps? id_bootcampNavigation { get; set; }

    [ForeignKey("id_usuario")]
    [InverseProperty("users_bootcamps")]
    public virtual users? id_usuarioNavigation { get; set; }
}
