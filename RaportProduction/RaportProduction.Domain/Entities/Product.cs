namespace RaportProduction.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }

    public Raport Raport { get; set;}
}