package AbstractFactory.BMW;

import AbstractFactory.interfaces.IWheels;

public class BMWWheels implements IWheels {
    private String name = "BMW M6 GT3 wheels";
    @Override
    public String getName() {
        return name;
    }
}
