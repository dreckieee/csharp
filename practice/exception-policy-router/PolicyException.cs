public class PolicyException : Exception
{
    public PolicyCode Code {get; private set;}
    public PolicyException (string message, PolicyCode code) : base (message)
    {
        Code = code;
    }
}