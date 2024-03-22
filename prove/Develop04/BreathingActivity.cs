using System.Data;
using System.Runtime.InteropServices;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing";
        _description = "This Activity will help you relax by walking you though breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write($"\nNow breathe out...");
            ShowCountDown(6);
            Console.WriteLine(" ");
        }
    }
}