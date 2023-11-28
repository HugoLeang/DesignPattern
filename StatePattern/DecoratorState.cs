using DesignPattern.Decorator;

namespace DesignPattern.StatePattern;

public class DecoratorState : IState
{
    public void Enter()
    {
      
    }

    public void Running(string command)
    {
        IEquipment baseItem = new Item("Sword");
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
       
    }
}