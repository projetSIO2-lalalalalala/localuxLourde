using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("modele")]
public partial class Modele
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("libelle")]
    public string Libelle { get; set; } = null!;

    [Column("nb_places")]
    public int NbPlaces { get; set; }

    [Column("tarif_km_hors_forfait")]
    public int TarifKmHorsForfait { get; set; }

    [Column("tarif_km")]
    public int TarifKm { get; set; }

    [Column("tarif_location_chauffeur")]
    public int? TarifLocationChauffeur { get; set; }

    public virtual ICollection<Vehicule> Vehicules { get; set; } = new List<Vehicule>();
    public virtual ICollection<Composant> Composants { get; set; } = new List<Composant>();
}
