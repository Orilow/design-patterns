package AbstractFactory.interfaces;

public interface ICarFactory {
    IEngine CreateEngine();
    IBody CreateBody();
    ISalon CreateSalon();
    IWheels CreateWheels();
}
