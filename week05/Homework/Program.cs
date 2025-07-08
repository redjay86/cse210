using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment assignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetWritingInformation());
    }
}