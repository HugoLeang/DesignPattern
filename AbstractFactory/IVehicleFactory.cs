namespace DesignPattern.AbstractFactory;

public interface IVehicleFactory
{
    Car CreateCar();
    Scooter CreateScooter();
}