using System;

class Program
{
    static void Main(string[] args)
    {
        // Criar o GoalManager
        GoalManager manager = new GoalManager();

        // Criar algumas metas
        SimpleGoal simple = new SimpleGoal("Run Marathon", "Complete a full marathon", 1000);
        EternalGoal eternal = new EternalGoal("Read Scriptures", "Read daily scriptures", 100);
        ChecklistGoal checklist = new ChecklistGoal("Temple Visits", "Attend temple 10 times", 50, 10, 500);

        // Adicionar metas ao manager
        manager.AddGoal(simple);
        manager.AddGoal(eternal);
        manager.AddGoal(checklist);

        // Mostrar metas
        manager.DisplayGoals();

        // Registrar eventos
        Console.WriteLine("\n--- Recording Events ---\n");
        manager.RecordEvent(0); // SimpleGoal
        manager.RecordEvent(1); // EternalGoal
        manager.RecordEvent(2); // ChecklistGoal
        manager.RecordEvent(2); // ChecklistGoal novamente

        // Mostrar metas atualizadas
        Console.WriteLine("\n--- Updated Goals ---\n");
        manager.DisplayGoals();

        // Mostrar pontuação total
        manager.DisplayScore();
    }
}
