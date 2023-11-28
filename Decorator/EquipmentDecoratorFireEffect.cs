namespace DesignPattern.Decorator;

public class EquipmentDecoratorFireEffect : EquipmentDecoratorBase
{
    public EquipmentDecoratorFireEffect(Equipment baseEquipment) : base(baseEquipment)
    {
    }

    public override void UseItem()
    {
        base.UseItem();
        Console.WriteLine($"{m_Equipment.GetName()} => Play Fire effect !");
    }
}