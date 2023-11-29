namespace DesignPattern.AbstractFactory;

public interface IVehicleFactory
{
    Car CreateCar(string name,string color);
    Scooter CreateScooter(string name,string color);
}