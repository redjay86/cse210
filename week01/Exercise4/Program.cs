using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num;
        List<int> nums = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0) { nums.Add(num); }

        } while (num != 0);

        int sum = nums.Sum();
        float mean = sum / nums.Count();
        int max = nums.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {mean}");
        Console.WriteLine($"The largest numer is: {max}");

        nums.Sort();
        foreach (int n in nums)
        {
            Console.WriteLine($"{n}");
        }
    }
}