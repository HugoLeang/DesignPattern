﻿namespace DesignPattern.StatePattern;
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
            case "BUILDER":
                MenuSystem.Instance.SwitchState(new BuilderState());
                break;
            case "COMPOSITE":
                MenuSystem.Instance.SwitchState(new CompanyTreeState());
                break;
            case "DECORATOR":
                MenuSystem.Instance.SwitchState(new DecoratorState());
                break;
        }
    }

    public void Exit()
    {
    }

    public void DisplayAvailableCommand()
    {
        Console.WriteLine("- CATALOG : Go to Catalog \n" +
                          "- BUILDER : Go to Builder \n" +
                          "- COMPOSITE : Go to Composite \n "
                          +"- DECORATOR : Go to Decorator \n");
    }
}