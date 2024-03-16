using System.Runtime.CompilerServices;

class Word
{
    // Member variables
    private string _text;
    private bool _isHidden;

    // Constructors
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Methods
    public void Hide()
    {
        string hide = new string ('_', _text.Length);
        _text = hide;
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return $"{_text}";
    }
}