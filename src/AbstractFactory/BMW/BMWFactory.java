package AbstractFactory.BMW;

import AbstractFactory.interfaces.*;

public class BMWFactory implements ICarFactory {

    @Override
    public IEngine CreateEngine() {
        return new BMWEngine();
    }

    @Override
    public IBody CreateBody() {
        return new BMWBody();
    }

    @Override
    public ISalon CreateSalon() {
        return new BMWSalon();
    }

    @Override
    public IWheels CreateWheels() {
        return new BMWWheels();
    }
}
