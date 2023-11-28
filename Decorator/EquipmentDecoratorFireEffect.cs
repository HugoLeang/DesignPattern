namespace DesignPattern.Decorator;

public class EquipmentDecoratorFireEffect : EquipmentDecoratorBase
{
    public EquipmentDecoratorFireEffect(IEquipment baseEquipment) : base(baseEquipment)
    {
    }

    public void UseItem()
    {
        m_Equipment.UseItem();
        Console.WriteLine($"{m_Equipment.GetName()} => Play Fire effect !");
    }
}