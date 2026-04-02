using System.ComponentModel.DataAnnotations.Schema;

namespace localux.Models;

[Table("location")]
public partial class LocationAvecChauffeur : Location
{
    [Column("la_destination_id")]
    public int? LaDestinationId { get; set; }

    [ForeignKey("LaDestinationId")]
    public virtual Destination? LaDestination { get; set; }
}