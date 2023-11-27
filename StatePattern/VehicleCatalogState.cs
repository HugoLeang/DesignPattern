using DesignPattern.AbstractFactory;

namespace DesignPattern.StatePattern;
using MenuSystem;
public class VehicleCatalogState : IState
{
    public void Enter()
    {
        Console.WriteLine("=== Vehicle Catalog ===");
        DisplayAvailableCommand();
    }

    public void Running(string command)
    {
        switch (command)
        {
            case"ELECTRIC":
                Catalog electricCatalog = new Catalog(Catalog.CatalogType.ELECTRIC);
                electricCatalog.GetCar().DisplayData();
                electricCatalog.GetScooter().DisplayData();
                break;
            case"FUEL":
                Catalog fuelCatalog = new Catalog(Catalog.CatalogType.FUEL);
                fuelCatalog.GetCar().DisplayData();
                fuelCatalog.GetScooter().DisplayData();
                break;
            
        }
    }

    public void Exit()
    {
        Console.WriteLine("==== Exit Catalog ====");
    }

    public void DisplayAvailableCommand()
    {
        Console.WriteLine("AVAILLABLE COMMAND: \n - FUEL : Display all fueled vehicle \n - ELECTRIC : Display all electric vehicle");
    }
}