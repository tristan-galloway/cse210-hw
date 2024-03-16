using System.Reflection;
using System.Text;

class Scripture
{
    // Member Variables
    private Reference _reference;
    private List<Word> _words = new();

    // Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');

        foreach (string w in words)
        {
            Word oneWord = new(w);
            _words.Add(oneWord);
        }

    }

    // Methods
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random rnd = new();
            int wordIndex = rnd.Next(0, _words.Count);
            _words[wordIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        // Initialize a new string to hold the list of string member variables of the Word objects
        StringBuilder bodyText = new();

        // add each string variable of word object to the list.
        foreach (Word word in _words)
        {
            bodyText.Append($"{word.GetDisplayText()} ");
        }

        // Return the reference followed by the completed string.
        return $"{_reference.GetDisplayText()} {bodyText}";
    }

    public bool IsCompletelyHidden()
    {
        // Set default to assume their are words hidden
        bool notHidden = true;

        // Iterate through each word. If one isn't hidden, set return value to false
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                notHidden = false;
            } 
        }

        // return true if sentance is completely hidden. 
        // If returns false, words still aren't hidden.
        return notHidden;
    }
}