using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;

        while (response != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string answer = Console.ReadLine();
            response = int.Parse(answer);
        }
        
    }
}