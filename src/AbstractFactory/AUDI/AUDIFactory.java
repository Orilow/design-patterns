package AbstractFactory.AUDI;

import AbstractFactory.interfaces.*;

public class AUDIFactory implements ICarFactory {
    @Override
    public IEngine CreateEngine() {
        return new AUDIEngine();
    }

    @Override
    public IBody CreateBody() {
        return new AUDIBody();
    }

    @Override
    public ISalon CreateSalon() {
        return new AUDISalon();
    }

    @Override
    public IWheels CreateWheels() {
        return new AUDIWheels();
    }
}
