using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("client")]
public partial class Client
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("nom")]
    public string Nom { get; set; } = null!;

    [Column("prenom")]
    public string Prenom { get; set; } = null!;

    [Column("login")]
    public string Login { get; set; } = null!;

    [Column("mdp")]
    public string Mdp { get; set; } = null!;

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
