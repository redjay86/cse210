using System;

class Program
{
    static void Main(string[] args)
    {
        string play_again = "yes";
        while (play_again == "yes")
        {
            Random randomGen = new Random();
            int magic_num = randomGen.Next(1, 100);
            int guess;
            int i = 0;
            do
            {
                i++;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess > magic_num)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magic_num)
                {
                    Console.WriteLine("Higher");
                }
            } while (guess != magic_num);
            Console.WriteLine($"You guessed it in {i} guesses!");
            Console.Write("Would you like to play again? ");
            play_again = Console.ReadLine();
        } 
        }
}