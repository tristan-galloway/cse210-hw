class Word
{
    // Member variables
    private string _text;
    private bool _isHidden;

    // Constructors
    Word(string text)
    {
        _text = text;
    }

    // Methods
    public void Hide()
    {

    }

    public void Show()
    {

    }

    public bool isHidden()
    {
        return false;
    }

    public string GetDisplayText()
    {
        return $"{_text}";
    }
}