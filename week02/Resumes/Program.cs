using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Lets start.\n");

        Job job1 = new Job();
        job1._company = "Yuran Garoupa";
        job1._jobTitle = "Software Development";
        job1._startYear = 2014;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "InfoYu";
        job2._jobTitle = "Deputy Manager";
        job2._startYear = 2020;
        job2._endYear = 2024;

            Resume myResume = new Resume();
        myResume._name = "Yuran Nhangumbe";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}