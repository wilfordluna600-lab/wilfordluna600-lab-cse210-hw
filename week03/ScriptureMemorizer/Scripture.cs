public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();
        string[] wordList = text.Split(' ');
        foreach (string word in wordList)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenWordsCount = 0;
        while (hiddenWordsCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenWordsCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string showText = _reference.GetDisplayText();
        foreach (Word w in _words)
        {
            showText += w.GetDisplayText() + " ";
        }
        return showText;
    }

    public bool IsCompletelyHidden()
    {

        return false;
    }
}