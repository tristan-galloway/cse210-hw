using System;
using System.Formats.Asn1;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new();
        int choice;

        do
        {
            gm.DisplayPlayerInfo();
            gm.Start();
            string answer = Console.ReadLine();
            choice = int.Parse(answer);

            switch (choice)
            {
                case 1:
                    gm.CreateGoal();
                    break;
                case 2:
                    gm.ListGoalNames();
                    break;
                case 3:
                    gm.SaveGoals();
                    break;
                case 4:
                    gm.LoadGoals();
                    break;
                case 5:
                    gm.RecordEvent();
                    break;
            }

        } while (choice != 6);  
    }
}