using System;
using System.Threading;

namespace MindfulnessProgram
{
    public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _durationSeconds;

        // Log simples em memória (criatividade)
        protected static string activityLog = "";

        public void SetDuration(int durationSeconds)
        {
            _durationSeconds = durationSeconds;
        }

        public void DisplayStartMessage()
        {
            Console.Clear();
            Console.WriteLine($"Starting {_name}");
            Console.WriteLine(_description);
            Console.WriteLine($"Duration: {_durationSeconds} seconds");
            Console.WriteLine("Prepare to begin...");
            ShowCountdown(3);
        }

        public void DisplayEndMessage()
        {
            Console.WriteLine("Well done!");
            ShowCountdown(2);
            Console.WriteLine($"You have completed {_name} for {_durationSeconds} seconds.");
            // Adiciona ao log
            activityLog += $"{_name} - {_durationSeconds} seconds\n";
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected void ShowSpinner(int seconds)
        {
            char[] spinner = { '|', '/', '-', '\\' };
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }

        // Método abstrato que cada classe concreta deve implementar
        public abstract void Run();

        // Método para mostrar log das atividades concluídas
        public static void ShowActivityLog()
        {
            Console.WriteLine("Activity Log:");
            if (string.IsNullOrEmpty(activityLog))
            {
                Console.WriteLine("No activities completed yet.");
            }
            else
            {
                Console.WriteLine(activityLog);
            }
        }
    }
}
