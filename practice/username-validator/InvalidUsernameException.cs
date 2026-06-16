public class InvalidUsernameException : Exception
{
    public string Username {get; private set;}
    public InvalidUsernameException (string message, string username) : base (message)
    {
        Username = username;
    }
}
