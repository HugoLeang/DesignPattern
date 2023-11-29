using DesignPattern.Decorator;

namespace DesignPattern.StatePattern;

public class DecoratorState : IState
{
    private Equipment m_BaseItem;

    public void Enter()
    {
        m_BaseItem = new Item("Sword");
        DisplayAvailableCommand();
    }

    public void Running(string command)
    {
        switch (command)
        {
            case "FIRE":
                m_BaseItem = new EquipmentDecoratorFireEffect(m_BaseItem);
                break;
            case "ICE":
                m_BaseItem = new EquipementDecoratorIceEffect(m_BaseItem);
                break;
            case "USE":
                m_BaseItem.UseItem();
                break;
            case "RESET":
                m_BaseItem = new Item("Sword");
                break;
        }
    }

    public void Exit()
    {
    }

    public void DisplayAvailableCommand()
    {
        Console.WriteLine("- FIRE : Decorate with a FIRE Decorator \n" +
                          "- ICE : Decorate with ICE Decorator \n" + 
                          "- USE : Use item with all Decorators \n" +
                          "- RESET : Reset item without decorators");
    }
}