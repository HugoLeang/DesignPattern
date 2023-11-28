namespace DesignPattern.Decorator;

public class Item : IEquipment
{
    public string m_ItemName { get; private set; }

    public Item(string name = "Default name")
    {
        m_ItemName = name;
    }
    
    public void UseItem()
    {
        Console.WriteLine($"Using {m_ItemName} !");
    }

    public string GetName()
    {
        return m_ItemName;
    }
}