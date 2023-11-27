namespace DesignPattern;

public class Vehicle
{
    private string m_VehicleName;
    private string m_EngineType;

    public Vehicle(string vehicleName, string engineType)
    {
        m_VehicleName = vehicleName;
        m_EngineType = engineType;
    }
    
    public void DisplayData()
    {
        Console.WriteLine($"{m_VehicleName} - {m_EngineType}");    
    }
}