using System.ComponentModel;

namespace WinFormsApp1;

public class Country
{
    public int CountryId { get; set; }

    public string? Name { get; set; }

    public int ContinentId { get; set; }
    public virtual Continent Continent { get; set; } = null!;
}