using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("log_connexion")]
public partial class LogConnexion
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("action")]
    public string Action { get; set; } = null!;

    [Column("date_heure")]
    public DateTime DateHeure { get; set; }

    [Column("le_employe_id")]
    public int LeEmployeId { get; set; }
    [ForeignKey("LeEmployeId")]
    public virtual Employe LeEmploye { get; set; } = null!;
}
