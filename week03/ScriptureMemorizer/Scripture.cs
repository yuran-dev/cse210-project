using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    // Construtor: recebe a referência e o texto completo
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        string[] splitWords = text.Split(' '); // separa o texto em palavras
        foreach (string word in splitWords)
        {
            words.Add(new Word(word));
        }
    }

    // Exibe a escritura no console
    public void Display()
    {
        Console.WriteLine(reference.GetReference());
        foreach (Word w in words)
        {
            Console.Write(w.Display() + " ");
        }
        Console.WriteLine("\n");
    }

    // Esconde palavras aleatórias
    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < count)
        {
            int index = rand.Next(words.Count);
            if (!words[index].IsHidden())
            {
                words[index].Hide();
                hiddenCount++;
            }

            // Sai do loop se todas as palavras já estiverem escondidas
            if (AllHidden())
                break;
        }
    }

    // Verifica se todas as palavras estão escondidas
    public bool AllHidden()
    {
        foreach (Word w in words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}
