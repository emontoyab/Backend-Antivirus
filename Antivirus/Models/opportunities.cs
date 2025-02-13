using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class opportunities
{
    [Key]
    public long id { get; set; }

    [StringLength(255)]
    public string? adicional_dates { get; set; }

    [StringLength(144)]
    public string? applications { get; set; }

    [StringLength(255)]
    public string? contact_channels { get; set; }

    [StringLength(255)]
    public string? descriptions { get; set; }

    [StringLength(255)]
    public string? guide { get; set; }

    [StringLength(255)]
    public string? name { get; set; }

    [StringLength(255)]
    public string? observations { get; set; }

    [StringLength(255)]
    public string? requeriments { get; set; }

    public long? id_categories { get; set; }

    public long? id_status_review { get; set; }

    public long? oportunity_type { get; set; }

    [MaxLength(1)]
    public char? trial755 { get; set; }

    [ForeignKey("id_categories")]
    [InverseProperty("opportunities")]
    public virtual categories_opportunities? id_categoriesNavigation { get; set; }

    [ForeignKey("id_status_review")]
    [InverseProperty("opportunities")]
    public virtual status_opportunities? id_status_reviewNavigation { get; set; }

    [InverseProperty("id_opportunitiesNavigation")]
    public virtual ICollection<institute_opportunities> institute_opportunities { get; set; } = new List<institute_opportunities>();

    [ForeignKey("oportunity_type")]
    [InverseProperty("opportunities")]
    public virtual type_opportunities? oportunity_typeNavigation { get; set; }

    [InverseProperty("id_opportunityNavigation")]
    public virtual ICollection<user_oportunities> user_oportunities { get; set; } = new List<user_oportunities>();
}
