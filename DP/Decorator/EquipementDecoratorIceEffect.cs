namespace DesignPattern.Decorator;

public class EquipementDecoratorIceEffect : EquipmentDecoratorBase
{
    public EquipementDecoratorIceEffect(Equipment baseEquipment) : base(baseEquipment)
    {
    }

    public override void UseItem() 
    {
        base.UseItem();
        Console.WriteLine($"{m_Equipment.GetName()} => Play Ice effect !");
    }

    public override string GetName()
    {
        throw new NotImplementedException();
    }
}