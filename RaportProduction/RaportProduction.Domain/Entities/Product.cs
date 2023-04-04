namespace RaportProduction.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int RaportId { get; set; }

    public Raport Raport { get; set;}
}