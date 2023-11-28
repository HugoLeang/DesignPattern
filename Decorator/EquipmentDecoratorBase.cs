namespace DesignPattern.Decorator;

public abstract class EquipmentDecoratorBase : IEquipment
{
    public IEquipment m_Equipment { get; private set; }
    public EquipmentDecoratorBase(IEquipment baseEquipment)
    {
        m_Equipment  = baseEquipment;
    }

    public void UseItem()
    {
        m_Equipment.UseItem();
    }

    public string GetName()
    {
        return m_Equipment.GetName();
    }
}