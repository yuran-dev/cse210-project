using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
        {
            _name = "Listing Activity";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        public override void Run()
        {
            DisplayStartMessage();

            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            Console.WriteLine("You have 3 seconds to prepare...");
            ShowCountdown(3);

            int elapsed = 0;
            int itemsCount = 0;
            DateTime startTime = DateTime.Now;

            while ((DateTime.Now - startTime).TotalSeconds < _durationSeconds)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                    itemsCount++;
            }

            Console.WriteLine($"You listed {itemsCount} items!");
            DisplayEndMessage();
        }
    }
}
