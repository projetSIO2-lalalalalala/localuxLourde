using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("historique_mdp")]
public partial class HistoriqueMdp
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("mdp")]
    public string Mdp { get; set; } = null!;

    [Column("date_modification")]
    public DateTime DateModification { get; set; }

    [Column("le_employe_id")]
    public int LeEmployeId { get; set; }
    [ForeignKey("LeEmployeId")]
    public virtual Employe LeEmploye { get; set; } = null!;
}