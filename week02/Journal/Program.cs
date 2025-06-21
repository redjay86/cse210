using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

// I added features to ensure the entries would be saved to a file letting the 
// user have the option to save the entries written before loading a new file.


class Program
{
    static void Main(string[] args)
    {
        string response;
        Journal myJournal = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();

            if (response == "1")
            {
                Entry entry = new Entry();
                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                myJournal.AddEntry(entry);
            }
            else if (response == "2")
            {
                myJournal.DisplayAll();
            }
            else if (response == "3")
            {
                if (!myJournal._changesSaved)
                {
                    Console.WriteLine("There are entries that have not been saved. Please select one of the following:");
                    Console.WriteLine("1. Do not save and load new file\n2. Save file and load new file");
                    response = Console.ReadLine();
                    if (response == "2")
                    {
                        Console.Write("Insert the name of the file to save to: ");
                        string saveFile = Console.ReadLine();
                        if (!saveFile.EndsWith(".txt"))
                        {
                            saveFile += ".txt";
                        }
                        myJournal.SaveToFile(saveFile);
                    }
                }

                Console.Write("Insert the name of the file to load from: ");
                string fileName = Console.ReadLine();
                if (!fileName.EndsWith(".txt"))
                {
                    fileName += ".txt";
                }
                if (!File.Exists(fileName))
                {
                    Console.WriteLine($"{fileName} does not exist.");
                }
                else
                {
                    myJournal.LoadFromFile(fileName);
                }
            }
            else if (response == "4")
            {
                Console.Write("Insert the name of the file to save to: ");
                string fileName = Console.ReadLine();
                if (!fileName.EndsWith(".txt"))
                {
                    fileName += ".txt";
                }
                myJournal.SaveToFile(fileName);
            }
            else if (response != "5")
            {
                Console.WriteLine("Not a valid response");
            }

        } while (response != "5");
    }
}