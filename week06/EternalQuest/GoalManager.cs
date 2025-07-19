using System.Net;
using System.Security.Cryptography;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string _fileName = "goals.txt";
    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        Console.WriteLine($"\nYou have {_score} points\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create new Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Undo Event");
        Console.WriteLine("  7. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = GetResponse(1, 7);
        if (choice == 1)
        {
            CreateGoal();
        }
        else if (choice == 2)
        {
            ListGoalDetails();
        }
        else if (choice == 3)
        {
            SaveGoals();
        }
        else if (choice == 4)
        {
            LoadGoals();
        }
        else if (choice == 5)
        {
            RecordEvent();
        }
        else if (choice == 6)
        {
            UndoEvent();
        }
        if (choice != 7)
        {
            Start();
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    private int GetResponse(int min, int max)
    {
        int choice;
        string response;
        response = Console.ReadLine();
        if (!int.TryParse(response, out choice))
        {
            Console.Write("Must be a number. Try again ");
            return GetResponse(min, max);
        }
        if (choice > max || choice < min)
        {
            Console.Write("That was not an option. Try again ");
            return GetResponse(min, max);
        }

        return choice;
    }

    private int GetNumberResponse(string prompt)
    {
        int res;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out res))
        {
            Console.WriteLine("Must be a number");
            Console.Write(prompt);
        }
        return res;
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = GetResponse(1, 3);
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write($"Write a description for {name}. ");
        string description = Console.ReadLine();
        int points = GetNumberResponse($"How many points is the {name} worth? ");

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == 3)
        {

            int target = GetNumberResponse($"How many times would you like to complete {name}? ");
            int bonus = GetNumberResponse($"How many bonues points will you get for completing {name} {target} times? ");
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }

    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which Goal did you complete? ");
        int choice = GetResponse(0, _goals.Count);
        _score += _goals[choice-1].RecordEvent();
    }
    
    public void UndoEvent()
    {
        ListGoalNames();
        Console.Write("Which Goal did you want to undo? ");
        int choice = GetResponse(0, _goals.Count);
        _score += _goals[choice-1].UndoEvent();
    }

    public void SaveGoals()
    {

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        _goals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        _score = int.Parse(lines[0]);
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(":");
            string type = parts[0];
            parts = parts[1].Split(",");
            if (type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
                if (bool.Parse(parts[3]))
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));

                for (int i = 0; i < int.Parse(parts[5]); i++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else
            {
                Console.WriteLine($"Could not load {type}");
            }
        }
    }
}