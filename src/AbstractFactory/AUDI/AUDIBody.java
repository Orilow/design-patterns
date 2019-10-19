package AbstractFactory.AUDI;

import AbstractFactory.interfaces.IBody;

public class AUDIBody implements IBody {
    private String name = "R8 Body KIT";

    @Override
    public String getName() {
        return name;
    }
}
