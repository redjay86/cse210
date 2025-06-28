class Scripture
{
    private Reference _reference;
    private List<Word> _words = [];

    public Scripture(Reference refe, string text)
    {
        _reference = refe;

        foreach (string word in text.Split(" ").ToList())
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            if (IsCompletelyHidden())
            {
                break;
            }
            while (true)
            {
                int idx = rand.Next(_words.Count);
                Word randWord = _words[idx];
                if (!randWord.IsHidden())
                {
                    randWord.Hide();
                    break;
                }
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string res = "";
        foreach (Word word in _words)
        {
            res += word.GetDisplayText() + " ";
        }
        return _reference.GetDisplayText() + res;
    }
}