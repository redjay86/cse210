class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        int waitTime = 5;
        base.DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(base.GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("\nBreathe in... ");
            base.ShowCountDown(waitTime);
            Console.Write("\nNow breathe out... ");
            base.ShowCountDown(waitTime);
        }
        base.AddRun();
    }
}