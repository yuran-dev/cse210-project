using System;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Show Activity Log"); // melhoria criativa
                Console.WriteLine("5. Quit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                Activity activity = null;

                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectionActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    case "4":
                        Console.Clear();
                        Activity.ShowActivityLog();
                        Console.WriteLine("Press Enter to return to the menu...");
                        Console.ReadLine();
                        continue;
                    case "5":
                        running = false;
                        continue;
                    default:
                        Console.WriteLine("Invalid choice. Press Enter to try again.");
                        Console.ReadLine();
                        continue;
                }

                // Pergunta a duração antes de iniciar qualquer atividade
                Console.Write("Enter duration in seconds: ");
                int duration;
                while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
                {
                    Console.Write("Invalid input. Enter a positive number: ");
                }
                activity.SetDuration(duration);

                // Executa a atividade selecionada
                activity.Run();

                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
