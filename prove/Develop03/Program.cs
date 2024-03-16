using System;
using System.Data;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        /*
        For the stretch challenge I was trying to select only words 
        that weren't hidden already with the HideRandomWords() method 
        but I can't seem to get it working.
        */

        // initialize the objects needed for app
        string scriptureBody = "Jesus answered and said unto him, Verily, verily, I say unto thee, Except a man be born again, he cannot see the kingdom of God.";
        Reference j35 = new("John", 3, 5);
        Scripture john35 = new(j35, scriptureBody);
        // Initialize sentinal
        bool keepPlaying = true;        

        do
        {
            Console.Clear();
            Console.WriteLine(john35.GetDisplayText());
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.Write("");
            string response = Console.ReadLine();

            if (response == "quit")
            {
                keepPlaying = false;
            };

            if (john35.IsCompletelyHidden() == true)
            {
                keepPlaying = false;
            }

            john35.HideRandomWords(3);

        } while (keepPlaying == true);
        
    }
}