using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class institute_bootcamps
{
    [Key]
    public long id { get; set; }

    public long? id_bootcamps { get; set; }

    public long? id_institutions { get; set; }

    [MaxLength(1)]
    public char? trial755 { get; set; }

    [ForeignKey("id_bootcamps")]
    [InverseProperty("institute_bootcamps")]
    public virtual bootcamps? id_bootcampsNavigation { get; set; }

    [ForeignKey("id_institutions")]
    [InverseProperty("institute_bootcamps")]
    public virtual institutions? id_institutionsNavigation { get; set; }
}
