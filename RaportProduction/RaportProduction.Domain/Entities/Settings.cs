
namespace RaportProduction.Domain.Entities;

public class Settings
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int Order { get; set; }

    public ICollection<SettingPosition> Positions { get; set; } = new HashSet<SettingPosition>();
}
