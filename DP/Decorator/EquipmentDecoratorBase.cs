namespace DesignPattern.Decorator;

public abstract class EquipmentDecoratorBase : Equipment
{
    public Equipment m_Equipment { get; private set; }
    public EquipmentDecoratorBase(Equipment baseEquipment)
    {
        m_Equipment  = baseEquipment;
    }

    public override void UseItem()
    {
        m_Equipment.UseItem();
    }

    public override string GetName()
    {
        return m_Equipment.GetName();
    }
}