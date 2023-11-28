namespace DesignPattern.Decorator;

public class Item : Equipment
{
    public string m_ItemName { get; private set; }

    public Item(string name = "Default name")
    {
        m_ItemName = name;
    }
    
    public override void UseItem()
    {
        Console.WriteLine($"Using {m_ItemName} !");
    }

    public override string GetName()
    {
        return m_ItemName;
    }
}