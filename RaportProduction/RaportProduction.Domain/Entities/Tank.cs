namespace RaportProduction.Domain.Entities;

public class Tank
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int NumberTanks { get; set; }

    public Raport Raport { get; set; }
}