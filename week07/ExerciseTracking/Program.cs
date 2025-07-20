using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("07 Jul 2025", 30f, 4.8f));
        activities.Add(new Cycling("06 Jul 2025", 60f, 15f));
        activities.Add(new Swimming("05, Jul 2025", 120f, 50));
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}