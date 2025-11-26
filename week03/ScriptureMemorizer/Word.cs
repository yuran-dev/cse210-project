public class Word
{
    private string text;
    private bool hidden;

    // Construtor: cria a palavra e define como visível
    public Word(string text)
    {
        this.text = text;
        hidden = false;
    }

    // Método para esconder a palavra
    public void Hide()
    {
        hidden = true;
    }

    // Método para verificar se a palavra está escondida
    public bool IsHidden()
    {
        return hidden;
    }

    // Método para exibir a palavra (ou underscores se estiver escondida)
    public string Display()
    {
        if (hidden)
            return new string('_', text.Length);
        else
            return text;
    }
}
