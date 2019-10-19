package AbstractFactory.AUDI;

import AbstractFactory.interfaces.IWheels;

public class AUDIWheels implements IWheels {
    private String name = "R8 Wheels";

    @Override
    public String getName() {
        return name;
    }
}
