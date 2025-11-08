using System;

class Program
{
    static void Main(string[] args)
    {
        // Cria o journal e o gerador de prompts
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int option = 0;

        Console.WriteLine("Welcome to the Journal Project!");

        while (option != 5)
        {
            // Menu principal
            Console.WriteLine("\n=== Journal Menu ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            
            string input = Console.ReadLine();
            if (!int.TryParse(input, out option))
            {
                Console.WriteLine("Invalid option. Please enter a number from 1 to 5.");
                continue;
            }

            Console.Clear();

            switch (option)
            {
                case 1:
                    // Nova entrada
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    Entry newEntry = new Entry(date, prompt, response);
                    journal.AddEntry(newEntry);

                    Console.WriteLine("✅ Entry added!");
                    break;

                case 2:
                    // Exibir diário
                    Console.WriteLine("=== Journal Entries ===");
                    journal.DisplayJournal();
                    break;

                case 3:
                    // Salvar diário
                    Console.Write("Enter filename to save (ex: journal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case 4:
                    // Carregar diário
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case 5:
                    // Sair
                    Console.WriteLine("Exiting the Journal. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose 1-5.");
                    break;
            }
        }
    }
}