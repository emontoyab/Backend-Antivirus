using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class institute_opportunities
{
    [Key]
    public long id { get; set; }

    public long? id_institutions { get; set; }

    public long? id_opportunities { get; set; }

    [MaxLength(1)]
    public char? trial755 { get; set; }

    [ForeignKey("id_institutions")]
    [InverseProperty("institute_opportunities")]
    public virtual institutions? id_institutionsNavigation { get; set; }

    [ForeignKey("id_opportunities")]
    [InverseProperty("institute_opportunities")]
    public virtual opportunities? id_opportunitiesNavigation { get; set; }
}
