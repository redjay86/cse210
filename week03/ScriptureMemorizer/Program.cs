using System;

class Program
{
    static void Main(string[] args)
    {
        Reference refe = new Reference("2 Nephi", 31, 11, 12);
        string text = "And the Father said: Repent ye, repent ye, and be baptized in the name of my Beloved Son. And also, the voice of the Son came unto me, saying: He that is baptized in my name, to him will the Father give the Holy Ghost, like unto me; wherefore, follow me, and do the things which ye have seen me do.";
        Scripture scripture = new Scripture(refe, text);

        string response;
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            scripture.HideRandomWords(3);
        } while (!scripture.IsCompletelyHidden() && response != "quit");
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}