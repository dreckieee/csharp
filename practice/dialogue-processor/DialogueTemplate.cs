public class DialogueTemplate
{
    public string Template {get; private set;}
    public DialogueTemplate (string template)
    {
        Template = template;
    }

    public string Process (Dictionary<string, string> placeholders)
    {
        string processedPlaceholder = Template;
        foreach (KeyValuePair<string, string> pair in placeholders)
        {
            processedPlaceholder = processedPlaceholder.Replace("{" + pair.Key + "}", pair.Value);
        }
        return processedPlaceholder;
    }
}