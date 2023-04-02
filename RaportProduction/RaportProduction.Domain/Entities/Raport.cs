using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RaportProduction.Domain.Entities;

public class Raport
{

    public int Id { get; set; }
    public int Quantity { get; set; }
    public string Comments { get; set; }
    public string UserId { get; set; }


    public ApplicationUser User { get; set; }
    public Product Product { get; set; }
    public Container Containers { get; set; }
    public ProductionTime ProductionTime { get; set; }

}