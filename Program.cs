using DesignPattern.AbstractFactory;

public static class Program
{
    private static void Main(string[] args)
    {
        Catalog electricCatalog = new Catalog(Catalog.CatalogType.ELECTRIC);
        electricCatalog.GetCar().DisplayData();
        electricCatalog.GetScooter().DisplayData();
        Catalog fuelCatalog = new Catalog(Catalog.CatalogType.FUEL);
        fuelCatalog.GetCar().DisplayData();
        fuelCatalog.GetScooter().DisplayData();
    }
}
