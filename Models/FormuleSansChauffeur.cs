using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("formule_sans_chauffeur")]
public partial class FormuleSansChauffeur
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("libelle")]
    public string Libelle { get; set; } = null!;

    [Column("duree")]
    public int Duree { get; set; }

    [Column("forfait_km")]
    public int ForfaitKm { get; set; }

    public virtual ICollection<LocationSansChauffeur> LocationsSansChauffeur { get; set; } = new List<LocationSansChauffeur>();
}
