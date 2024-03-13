class Scripture
{
    // Member Variables
    private Reference _reference;
    private List<Word> _words;

    // Constructors
    Scripture(Reference reference, string text)
    {
        _reference = reference;
        // figure out how to split up the text and assign it to individual word objects
    }

    // Methods
    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return " ";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}