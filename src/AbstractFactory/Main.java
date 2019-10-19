package AbstractFactory;

import AbstractFactory.AUDI.AUDIFactory;
import AbstractFactory.BMW.BMWFactory;

public class Main {
    public static void main(String[] args) {
        BMWFactory bmw = new BMWFactory();
        AUDIFactory audi = new AUDIFactory();
    }
}
