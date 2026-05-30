public class Word
{
    private string _text;
    private bool _isHidden;

    Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        // maybe I will modify this later, I am 
        // going to think about it
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        // I am going to continue with this part tomorrow,
        // about the case when _isHidden is true.
        // maybe I will change this part later, I 
        // am going to think about it more
        return _text;
    }
}