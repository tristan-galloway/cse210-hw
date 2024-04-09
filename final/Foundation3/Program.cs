using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new();
        Address a1 = new("1011 Deon Dr", "Pocatello", "ID", "United States of America");
        Address a2 = new("505 Yale Ave", "Rexburg", "ID", "United States of America");
        Address a3 = new("123 Canada Drive", "Montreal", "Quebec", "Canada");

        Reception r = new("Galloways", "The wedding reception for Samantha and Tristan.", "1/6/24", "6:00 - 8:00", a1, "tristan.a.galloway@gmail.com");
        events.Add(r);

        Gathering g = new("Music Festival", "Hear from artists all over the area at this music festival.", "7/15/24", "8:00pm", a2, "Clear 32 Degrees.");
        events.Add(g);

        Lecture l = new("CSE210 Week 1", "This lecture will be focused on the fundementals of the c# programming language.", "4/24/24", "10:15am", a3, "Eric Carter", 50);
        events.Add(l);

        Console.Clear();

        foreach(Event e in events)
        {
            Console.WriteLine("Stadard Details");
            e.GetStandardDetails();
            Console.WriteLine("\n\nShort Details");
            e.GetShortDetails();
            Console.WriteLine("\n\nFull Details");
            e.GetFullDetails();
            Console.WriteLine("--------------------------------------------");
        }
    }
}