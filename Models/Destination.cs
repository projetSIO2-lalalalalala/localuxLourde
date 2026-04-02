using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("destination")]
public partial class Destination
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("libelle")]
    public string Libelle { get; set; } = null!;

    public virtual ICollection<LocationAvecChauffeur> LocationsAvecChauffeur { get; set; } = new List<LocationAvecChauffeur>();
    public virtual ICollection<Vehicule> Vehicules { get; set; } = new List<Vehicule>();
}
