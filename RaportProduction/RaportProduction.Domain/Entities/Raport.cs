
namespace RaportProduction.Domain.Entities;

public class Raport
{

    public int Id { get; set; }
    public int Quantity { get; set; }
    public string Comments { get; set; }
    public string UserId { get; set; }
    public int TankId { get; set; }
    public int ProductId { get; set; }
    public int ProductionTimeId { get; set; }


    public ApplicationUser User { get; set; }
    public Product Product { get; set; }
    public Tank Tank { get; set; }
    public ProductionTime ProductionTime { get; set; }

}