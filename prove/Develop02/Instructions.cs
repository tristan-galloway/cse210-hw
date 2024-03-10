public class Instructions
{
    public string _instructions;

    public void Display()
    {
        _instructions = @"1. Write
2. Display
3. Load
4. Save
5. Quit";
        Console.WriteLine(_instructions);
    }
}