using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("composant")]
public partial class Composant
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("libelle")]
    public string Libelle { get; set; } = null!;

    public virtual ICollection<Modele> Modeles { get; set; } = new List<Modele>();
    public virtual ICollection<DommageControle> DommagesControles { get; set; } = new List<DommageControle>();
}
