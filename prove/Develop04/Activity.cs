public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {

    }

    public void DisplayStartingMessage()
    {

    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {
        while (seconds > 0)
        {
            // This animation takes 1 second to play
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            seconds -= 1;
        }
    }

    public void ShowCountDown(int seconds)
    {
        while (seconds > 0);
            Console.Write($"{seconds}");
            Thread.Sleep(500);
            Console.Write("\b \b");
            seconds -= 1;
    }
}