using DesignPattern.AbstractFactory;

namespace DesignPattern;

public class ElectricVehicleFactory : IVehicleFactory
{
    public Car CreateCar()
    {
        return new Car("Electric Car","Eletric Engine");
    }

    public Scooter CreateScooter()
    {
        return new Scooter("Eletric Scooter","Eletric Engine");
    }
}