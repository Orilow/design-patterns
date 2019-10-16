package Builder;

public class Letter {
    private String[] recepients;
    private String body;
    private String theme;

    Letter(String theme, String body, String[] recepients){
        this.theme = theme;
        this.body = body;
        this.recepients = recepients;
    }

    public void printLetter(){
        System.out.println(theme);
        for (String rec: recepients) {
            System.out.print(rec + " ");
        }
        System.out.println("\n" + body);
    }
}
