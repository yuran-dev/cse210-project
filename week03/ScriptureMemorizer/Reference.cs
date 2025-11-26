public class Reference
{
    private string book;
    private int chapter;
    private int verseStart;
    private int verseEnd;

    // Construtor para um único versículo
    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        verseStart = verse;
        verseEnd = verse;
    }

    // Construtor para intervalo de versículos
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

    // Método para retornar a referência formatada
    public string GetReference()
    {
        if (verseStart == verseEnd)
            return $"{book} {chapter}:{verseStart}";
        else
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
    }
}
