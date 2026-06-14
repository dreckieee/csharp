public class AccessException : PolicyException
{
    public AccessException (string message, PolicyCode code) : base (message, code) { }
}