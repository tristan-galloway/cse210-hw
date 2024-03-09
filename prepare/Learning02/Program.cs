using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";   
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Boeing";
        job2._jobTitle = "Programmer";
        job2._startYear = 2015;
        job2._endYear = 2018;

        Resume resume1 = new Resume();
        resume1._name = "Tristan Galloway";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}