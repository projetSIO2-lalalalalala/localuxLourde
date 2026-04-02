using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("dommage_controle")]
public partial class DommageControle
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("le_composant_id")]
    public int LeComposantId { get; set; }
    [ForeignKey("LeComposantId")]
    public virtual Composant LeComposant { get; set; } = null!;

    [Column("la_location_id")]
    public int LaLocationId { get; set; }
    [ForeignKey("LaLocationId")]
    public virtual LocationSansChauffeur LaLocation { get; set; } = null!;

    [Column("le_type_dommage_id")]
    public int LeTypeDommageId { get; set; }
    [ForeignKey("LeTypeDommageId")]
    public virtual TypeDommage LeTypeDommage { get; set; } = null!;
}
