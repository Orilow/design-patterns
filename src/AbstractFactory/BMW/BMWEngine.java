package AbstractFactory.BMW;

import AbstractFactory.interfaces.IEngine;

public class BMWEngine implements IEngine {
    private String name = "slightly modified S63 production engine with M TwinPower turbo technology";

    @Override
    public String getName() {
        return name;
    }
}
