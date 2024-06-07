using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WinFormsApp1;

public class Continent
{
    public int ContinentId { get; set; }

    public string? Name { get; set; }

    public virtual ObservableCollectionListSource<Country> Countries { get; } = new();
}