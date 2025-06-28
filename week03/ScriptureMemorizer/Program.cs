using System;

class Program
{
    // You can type specific verses from the Book of Mormon. I added a ScriptureParser class that parses through a txt file online and
    // finds the specific verses. I didn't add any error handling, but if you type the book correctly and verses that exisists, it will work.
    static void Main(string[] args)
    {
        Console.Write("From what book in the Book of Mormon do you want to memorize: ");
        string book = Console.ReadLine();

        Console.Write("Chapter: ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Verse: ");
        int startVerse = int.Parse(Console.ReadLine());

        Console.Write("End Verse (If you only want to memorize one verse, just leave blank): ");
        string endVerseString = Console.ReadLine();

        Reference reference;

        int endVerse;
        if (int.TryParse(endVerseString, out endVerse))
        {
            reference = new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            reference = new Reference(book, chapter, startVerse);
        }

        ScriptureParser scriptureParser = new ScriptureParser(reference);
        Scripture scripture = scriptureParser.GetScripture();

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