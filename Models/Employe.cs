using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("employe")]
public partial class Employe
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("nom")]
    public string Nom { get; set; } = null!;

    [Column("prenom")]
    public string Prenom { get; set; } = null!;

    [Column("mdp")]
    public string Mdp { get; set; } = null!;

    [Column("date_modification_mdp")]
    public DateTime? DateModificationMdp { get; set; }

    [Column("salt")]
    public string Salt { get; set; } = null!;

    public virtual ICollection<HistoriqueMdp> HistoriqueMdps { get; set; } = new List<HistoriqueMdp>();
    public virtual ICollection<LogConnexion> LogConnexions { get; set; } = new List<LogConnexion>();
    public virtual ICollection<LocationSansChauffeur> LocationsSansChauffeur { get; set; } = new List<LocationSansChauffeur>();
}
