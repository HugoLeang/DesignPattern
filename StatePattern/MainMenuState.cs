namespace DesignPattern.StatePattern;
using MenuSystem;
using StatePattern;
public class MainMenuState : IState
{
    public void Enter()
    {
        Console.WriteLine("=== MAIN MENU ===");
        DisplayAvailableCommand();
    }

    public void Running(string command)
    {
        switch (command)
        {
            case "CATALOG":
                MenuSystem.Instance.SwitchState(new VehicleCatalogState());
                break;
        }
    }

    public void Exit()
    {
    }

    public void DisplayAvailableCommand()
    {
        Console.WriteLine("- CATALOG : Go to Catalog \n ");
    }
}