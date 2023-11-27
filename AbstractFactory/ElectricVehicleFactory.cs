using DesignPattern.AbstractFactory;

namespace DesignPattern;

public class ElectricVehicleFactory : IVehicleFactory
{
    public Car CreateCar(string name, string color)
    {
        return new Car(name,"Eletric Engine",color);
    }

    public Scooter CreateScooter(string name, string color)
    {
        return new Scooter(name,"Eletric Engine",color);
    }
}