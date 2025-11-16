using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Criar a referência da escritura
        Reference ref1 = new Reference("John", 3, 16);

        // 2. Criar a escritura com a referência e o texto
        Scripture scripture = new Scripture(ref1, "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.");

        // 3. Loop principal do programa
        while (!scripture.AllHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // esconde 3 palavras aleatórias
        }

        // 4. Mostrar o texto final completamente escondido
        Console.Clear();
        scripture.Display();
        Console.WriteLine("All words are hidden. Program ended.");
    }
}
