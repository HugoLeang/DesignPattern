namespace DesignPattern;

public class Vehicle
{
    private string m_VehicleName;
    private string m_EngineType;
    private string m_Color;
    public Vehicle(string vehicleName, string engineType,string color)
    {
        m_VehicleName = vehicleName;
        m_EngineType = engineType;
        m_Color = color;
    }
    
    public void DisplayData()
    {
        Console.WriteLine($"{m_VehicleName} - {m_EngineType} - {m_Color}");    
    }
}