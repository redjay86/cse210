using System.ComponentModel;
using System.Reflection;

class Activity
{
    private string _name;
    private string _desciption;
    private int _duration;
    private int _runs = 0;
    public Activity(string name, string description)
    {
        _name = name;
        _desciption = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine(_desciption);
        Console.Write("How long would you like to run the program in seconds? ");
        do
        {
            string respone = Console.ReadLine();
            while (!int.TryParse(respone, out _duration))
            {
                Console.WriteLine("Response not recognized. Please type a number of seconds");
                respone = Console.ReadLine();
            }
            if (_duration <= 0)
            {
                Console.WriteLine("Seconds must be a positive number");
            }
        } while (_duration <= 0);

        Console.WriteLine("Get ready...");
        ShowSpinner(2);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well Done!!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        int spinnerSpeed = 200;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(spinnerSpeed);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(spinnerSpeed);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(spinnerSpeed);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(spinnerSpeed);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void AddRun()
    {
        _runs++;
    }

    public int GetRuns()
    {
        return _runs;
    }
}