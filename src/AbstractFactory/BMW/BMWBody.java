package AbstractFactory.BMW;

import AbstractFactory.interfaces.IBody;

public class BMWBody implements IBody {
    private String name = "BMW M6 GT3 E63 WIDE-BODY KIT";

    @Override
    public String getName() {
        return name;
    }
}
