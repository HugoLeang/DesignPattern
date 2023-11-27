namespace DesignPattern.AbstractFactory;

public class Catalog
{
    private IVehicleFactory m_Factory;
    
    public enum CatalogType
    {
        NONE,
        FUEL,
        ELECTRIC,
    }

    public Catalog(CatalogType catalogType)
    {
        switch (catalogType)
        {
            case CatalogType.FUEL:
                m_Factory = new FuelVehicleFactory();
                break;
            case CatalogType.ELECTRIC:
                m_Factory = new ElectricVehicleFactory();
                break;
        }
    }

    public Scooter CreateScooter(string name,string color)
    {
        return m_Factory.CreateScooter(name,color);
    }
    public Car CreateCar(string name,string color)
    {
        return m_Factory.CreateCar(name,color);
    }
}