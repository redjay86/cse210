public class PromptGenerator()
{
    List<string> _prompts =
    [
        "What did you eat for lunch today?",
        "Who did you talk to the most today?",
        "What gave you the most joy today?",
        "Where did you see the Lord's hand in your day?",
        "How did you serve someone today?",
        "When were you most happy today?"
    ];

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}