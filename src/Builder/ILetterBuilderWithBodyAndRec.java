package Builder;

public interface ILetterBuilderWithBodyAndRec {
    ILetterBuilderWithBodyAndRec addTheme(String theme);
    Letter build();
}
