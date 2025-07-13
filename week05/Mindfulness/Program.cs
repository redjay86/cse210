using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"    1. Start breathing activity ({breathingActivity.GetRuns()})");
            Console.WriteLine($"    2. Start reflecting activity ({reflectingActivity.GetRuns()})");
            Console.WriteLine($"    3. Start listing activity ({listingActivity.GetRuns()})");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");
            int response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                breathingActivity.Run();
            }
            else if (response == 2)
            {
                reflectingActivity.Run();
            }
            else if (response == 3)
            {
                listingActivity.Run();
            }
            else if (response == 4)
            {
                Environment.Exit(0);
            }
        }
        

    }
}