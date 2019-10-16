package Builder;

class HelloWorld {
    public static void main(String[] args) {
        Letter l = new LetterBuilder()
                .addBody("BODY")
                .addRecepients(new String[]{"me", "your mum"})
                .addTheme("THEME")
                .build();
        l.printLetter();
    }
}