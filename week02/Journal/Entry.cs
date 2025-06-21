using System.Runtime.CompilerServices;

public class Entry
{
    public string _date = DateTime.Now.ToString("yyyy-MM-dd");
    public string _promptText = new PromptGenerator().GetRandomPrompt();
    public string _entryText = "";

    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}