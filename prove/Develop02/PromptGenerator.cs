public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        _prompts.Add("What is the current problem or challenge I am facing? ");
        _prompts.Add("What am I grateful for today? ");
        _prompts.Add("What was the most interesting thing I saw or heard today? ");
        _prompts.Add("What was the most surprising thing that happened today? ");
        _prompts.Add("What did I do today that I am proud of? ");
        _prompts.Add("What am I nervous or anxious about today? ");
        _prompts.Add("What is the current problem or challenge I am facing? ");
        
        int random_number = new Random().Next(0, _prompts.Count -1);

        return _prompts[random_number];
    }
}