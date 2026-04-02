using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("location")]
public partial class LocationSansChauffeur : Location
{
    [Column("date_heure_retour")]
    public DateTime? DateHeureRetour { get; set; }

    [Column("kilometrage_retour")]
    public int? KilometrageRetour { get; set; }

    [Column("cout_estimatif")]
    public int? CoutEstimatif { get; set; }

    [Column("la_formule_id")]
    public int? LaFormuleId { get; set; }
    [ForeignKey("LaFormuleId")]
    public virtual FormuleSansChauffeur? LaFormule { get; set; }

    [Column("le_employe_id")]
    public int? LeEmployeId { get; set; }
    [ForeignKey("LeEmployeId")]
    public virtual Employe? LeEmploye { get; set; }

    public virtual ICollection<DommageControle> DommagesControles { get; set; } = new List<DommageControle>();
}