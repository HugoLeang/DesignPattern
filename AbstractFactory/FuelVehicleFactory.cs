using DesignPattern.AbstractFactory;

namespace DesignPattern;

public class FuelVehicleFactory : IVehicleFactory
{
    public Car CreateCar(string name, string color)
    {
        return new Car("Fuel Car", "Fuel Engine",color);
    }

    public Scooter CreateScooter(string name, string color)
    {
        return new Scooter(name, "Fuel Engine",color);
    }
}