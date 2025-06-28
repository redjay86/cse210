using System.Net.Http;
using System.Text.RegularExpressions;

class ScriptureParser
{
    private Reference _reference;
    private string _txtFile;
    private Scripture _scripture;
    public ScriptureParser(Reference refe)
    {
        _reference = refe;
        using (var client = new HttpClient())
        {
            _txtFile = client.GetStringAsync("https://ia601205.us.archive.org/18/items/thebookofmormon00017gut/mormon13.txt").Result;
        }

        string text;
        //Just one verse
        if (_reference.GetVerse() == _reference.GetEndVerse())
        {
            text = GetVerseString($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetVerse()}");
        }
        else
        {
            text = "";
            for (int i = _reference.GetVerse(); i < _reference.GetEndVerse() + 1; i++)
            {
                text += GetVerseString($"{_reference.GetBook()} {_reference.GetChapter()}:{i}") + " ";
            }
        }
        _scripture = new Scripture(_reference, text);
    }

    private string GetVerseString(string verse)
    {
        //verse: {Book} {Chapter}:{Verse}
        int verseHeadingIndex = _txtFile.IndexOf(verse);
        int verseStartIndex = _txtFile.IndexOf("\r\n ", verseHeadingIndex);
        int verseEndIndex = _txtFile.IndexOf("\r\n\r\n", verseHeadingIndex);
        string res = _txtFile.Substring(verseStartIndex, verseEndIndex - verseStartIndex).Replace("\r\n ", "").Replace("\r\n", " ");
        res = Regex.Replace(res, @"\d+.", "");
        return res;
    }

    public Scripture GetScripture()
    {
        return _scripture;
    }
}