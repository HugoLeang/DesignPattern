namespace DesignPattern.Decorator;

public class EquipementDecoratorIceEffect : EquipmentDecoratorBase
{
    public EquipementDecoratorIceEffect(IEquipment baseEquipment) : base(baseEquipment)
    {
    }

    public void UseItem() 
    {
        m_Equipment.UseItem();
        Console.WriteLine($"{m_Equipment.GetName()} => Play Ice effect !");
    }
}