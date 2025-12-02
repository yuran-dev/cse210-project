using System;
using System.Threading;

namespace MindfulnessProgram
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            _name = "Breathing Activity";
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        public override void Run()
        {
            DisplayStartMessage();

            int elapsed = 0;
            while (elapsed < _durationSeconds)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(2);
                elapsed += 2;

                if (elapsed >= _durationSeconds) break;

                Console.WriteLine("Breathe out...");
                ShowCountdown(2);
                elapsed += 2;
            }

            DisplayEndMessage();
        }
    }
}
