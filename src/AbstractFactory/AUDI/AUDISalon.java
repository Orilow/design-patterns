package AbstractFactory.AUDI;

import AbstractFactory.interfaces.ISalon;

public class AUDISalon implements ISalon {
    private String name = "R8 Salon";

    @Override
    public String getName() {
        return name;
    }
}
