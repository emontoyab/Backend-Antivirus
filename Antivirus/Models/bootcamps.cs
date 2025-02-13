using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Models;

public partial class bootcamps
{
    [Key]
    public long id { get; set; }

    [StringLength(100)]
    public string nombre { get; set; } = null!;

    public long? id_costos_id { get; set; }

    public long? id_estado_id { get; set; }

    public long? id_general_id { get; set; }

    public long? id_temas_id { get; set; }

    [StringLength(255)]
    public string? informacion { get; set; }

    [MaxLength(1)]
    public char? trial751 { get; set; }

    [ForeignKey("id_costos_id")]
    [InverseProperty("bootcamps")]
    public virtual costs_bootcamps? id_costos { get; set; }

    [ForeignKey("id_estado_id")]
    [InverseProperty("bootcamps")]
    public virtual status_bootcamps? id_estado { get; set; }

    [ForeignKey("id_general_id")]
    [InverseProperty("bootcamps")]
    public virtual descriptions_bootcamps? id_general { get; set; }

    [ForeignKey("id_temas_id")]
    [InverseProperty("bootcamps")]
    public virtual topics_bootcamps? id_temas { get; set; }

    [InverseProperty("id_bootcampsNavigation")]
    public virtual ICollection<institute_bootcamps> institute_bootcamps { get; set; } = new List<institute_bootcamps>();

    [InverseProperty("id_bootcampNavigation")]
    public virtual ICollection<users_bootcamps> users_bootcamps { get; set; } = new List<users_bootcamps>();
}
