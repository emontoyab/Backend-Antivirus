using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class user_oportunities
{
    [Key]
    public long id { get; set; }

    public long? id_opportunity { get; set; }

    public long? id_user { get; set; }

    [MaxLength(1)]
    public char? trial755 { get; set; }

    [ForeignKey("id_opportunity")]
    [InverseProperty("user_oportunities")]
    public virtual opportunities? id_opportunityNavigation { get; set; }

    [ForeignKey("id_user")]
    [InverseProperty("user_oportunities")]
    public virtual users? id_userNavigation { get; set; }
}
