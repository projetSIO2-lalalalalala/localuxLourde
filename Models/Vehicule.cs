using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("vehicule")]
public partial class Vehicule
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("immat")]
    public string Immat { get; set; } = null!;

    [Column("le_modele_id")]
    public int LeModeleId { get; set; }

    [ForeignKey("LeModeleId")]
    public virtual Modele LeModele { get; set; } = null!;

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
    public virtual ICollection<Destination> Destinations { get; set; } = new List<Destination>();
}
