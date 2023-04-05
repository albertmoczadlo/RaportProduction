
namespace RaportProduction.Domain.Entities;

public class ProductionTime
{
    public int Id { get; set; }
    public DayOfWeek Day { get; set; }
    public DateTime StartProductionTime { get; set; }
    public DateTime? EndProductionTime { get; set; }

    public Raport Raport { get; set; }
}
