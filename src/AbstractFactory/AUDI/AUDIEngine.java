package AbstractFactory.AUDI;

import AbstractFactory.interfaces.IEngine;

public class AUDIEngine implements IEngine {
    private String name = "R8's V-10 engine";

    @Override
    public String getName() {
        return name;
    }
}
