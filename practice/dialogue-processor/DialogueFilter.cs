public class DialogueFilter
{
    public List<string> BannedWords {get; set;}
    public DialogueFilter (List<string> bannedWords)
    {
        BannedWords = bannedWords;
    }

    public bool IsClean(string word)
    {
        foreach(string b in BannedWords)
        {
            if (word.ToLower().Contains(b.ToLower())) {return false;}
        }
        return true;
    }

}