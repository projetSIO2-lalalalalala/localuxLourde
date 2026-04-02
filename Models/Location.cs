using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("location")]
public partial class Location
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("date_heure_enregistrement")]
    public DateTime DateHeureEnregistrement { get; set; }

    [Column("date_heure_depart")]
    public DateTime DateHeureDepart { get; set; }

    [Column("le_client_id")]
    public int LeClientId { get; set; }
    [ForeignKey("LeClientId")]
    public virtual Client LeClient { get; set; } = null!;

    [Column("le_vehicule_id")]
    public int LeVehiculeId { get; set; }
    [ForeignKey("LeVehiculeId")]
    public virtual Vehicule LeVehicule { get; set; } = null!;
}
