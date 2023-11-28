using DesignPattern.Decorator;

namespace DesignPattern.StatePattern;

public class DecoratorState : IState
{
    public void Enter()
    {
     DisplayAvailableCommand(); 
    }

    public void Running(string command)
    {
        Equipment baseItem = new Item("Sword");
        switch (command)
        {
            case "SIMPLE":
                EquipmentDecoratorFireEffect simpleFireDecorator = new EquipmentDecoratorFireEffect(baseItem);
                simpleFireDecorator.UseItem();
                break;
            case "COMPLEX":
                baseItem = new EquipmentDecoratorFireEffect(baseItem);
                baseItem = new EquipementDecoratorIceEffect(baseItem);
                baseItem.UseItem();
                break;
        }
    }

    public void Exit()
    {
    
    }

    public void DisplayAvailableCommand()
    {
        Console.WriteLine("- SIMPLE : Decorate with a simple Decorator \n" +
                          "- COMPLEX : Decorate with two Decorator ");
    }
}