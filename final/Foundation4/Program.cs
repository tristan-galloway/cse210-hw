using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new()
        {
            new Running(new DateTime(2022, 3, 17), 30, 3),
            new Swimming(new DateTime(2023, 4, 18), 30, 30),
            new Cycling(new DateTime(2024, 5, 19), 60, 10)
        };

        foreach (Activity a in activities)
        {
            a.GetSummary();
            Console.WriteLine(" ");
        }
    }
}