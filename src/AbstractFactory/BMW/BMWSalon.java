package AbstractFactory.BMW;

import AbstractFactory.interfaces.ISalon;

public class BMWSalon implements ISalon {
    private String name = "Салон BMW M6 GT3";

    @Override
    public String getName() {
        return name;
    }
}
