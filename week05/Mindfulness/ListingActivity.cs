class ListingActivity : Activity
{
    int _count = 0;
    List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }
    public void Run()
    {
        string prompt = GetRandomPrompt();
        base.DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(base.GetDuration());
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--{prompt}--");
        Console.Write("You may begin in: ");
        base.ShowCountDown(3);
        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        base.DisplayEndMessage();
        base.AddRun();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}