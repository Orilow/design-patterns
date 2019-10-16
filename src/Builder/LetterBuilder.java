package Builder;

public class LetterBuilder {

    public LetterBuilderWithBody addBody(String body) {
        return new LetterBuilderWithBody(body);
    }

    class LetterBuilderWithBody implements ILetterBuilderWithBody{
        private final String body;
        public LetterBuilderWithBody(String body) {
            this.body = body;
        }

        public LetterBuilderWithBodyAndRec addRecepients(String[] rec) {
            return new LetterBuilderWithBodyAndRec(body, rec);
        }
    }

    class LetterBuilderWithBodyAndRec implements ILetterBuilderWithBodyAndRec {
        private final String body;
        private final String[] rec;
        private String theme;
        public LetterBuilderWithBodyAndRec(String body, String[] rec){
            this.body = body;
            this.rec = rec;
        }

        public LetterBuilderWithBodyAndRec addTheme(String theme) {
            this.theme = theme;
            return this;
        }

        public Letter build(){
            return new Letter(theme, body, rec);
        }
    }
}
