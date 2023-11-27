using DesignPattern.AbstractFactory;

namespace DesignPattern;

public class FuelVehicleFactory : IVehicleFactory
{
    public Car CreateCar()
    {
        return new Car("Fuel Car", "Fuel Engine");
    }

    public Scooter CreateScooter()
    {
        return new Scooter("Fuel Scooter", "Fuel Engine");
    }
}