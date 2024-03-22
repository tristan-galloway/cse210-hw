using System.Text.RegularExpressions;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new();
    private List<string> _questions = new();

    public ReflectingActivity() : base()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have show strength and resilience. " +
        "This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");


        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");

    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Consider the following prompt:\n");
            DisplayPrompt();
            Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");
            Console.Write("");
            Console.ReadLine();
            Console.Clear();

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(20);
        }

    }

    public string GetRandomPrompt()
    {
        Random r = new();
        int promptIndex = r.Next(0, _prompts.Count - 1);

        return _prompts[promptIndex];
    }

    public string GetRandomQuestion()
    {
        Random r = new();
        int questionIndex = r.Next(0, _questions.Count);

        return _questions[questionIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
    }
}