namespace Uebung1.Domain;

public static class DomainDbContext
{
    public static IList<Auto> Autos { get; set; } = new List<Auto>();
}