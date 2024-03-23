public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new();
    private List<string> _responses = new();

    public ListingActivity() : base()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }

        Console.WriteLine($"You listed {_count} items!");
        Thread.Sleep(5000);
    }

    public void GetRandomPrompt()
    {
        Random r = new();
        int promptIndex = r.Next(0, _prompts.Count - 1);

        Console.WriteLine($" --- {_prompts[promptIndex]} ---");
    }

    public List<string> GetListFromUser()
    {
        Console.Write("> ");
        string response = Console.ReadLine();
        _responses.Add(response);
        _count = _responses.Count;

        return _responses;
    }
}