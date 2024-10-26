using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager(0);
        goalManager.Start();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Display Player info:");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create new Goal");
            Console.WriteLine("5. Record event for a goal");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Quit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                goalManager.DisplayPlayerInfo();
            }
            else if (choice == "2")
            {
                goalManager.ListGoalNames();
            }
            else if (choice == "3")
            {
                goalManager.ListGoalDetails();
            }
            else if (choice == "4")
            {
                goalManager.CreateGoal();
            }
            else if (choice == "5")
            {
                goalManager.RecordEvent();
            }
            else if (choice == "6")
            {
                goalManager.SaveGoals();
            }
            else if (choice == "7")
            {
                goalManager.LoadGoals();
            }
            else if (choice == "8")
            {
                Console.WriteLine("Exiting program, byebye");
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid option, Please select again.");
            }
        }
    }
}