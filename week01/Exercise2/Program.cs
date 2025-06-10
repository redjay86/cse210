using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percent grade did you get in the class? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        if (grade >= 90)
        {
            letter = "A";

        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congrats on passing the class!");
        }

        string extra = "";
        if (letter != "F" && letter != "A" && (grade % 10 >= 7))
        {
            extra = "+";
        }
        else if (letter != "F" && letter != "A" && (grade % 10 < 3))
        {
            extra = "-";
        }
        Console.Write($"You got a {letter}{extra}");
    }
}