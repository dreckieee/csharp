public class QuotaException : PolicyException
{
    public QuotaException (string message, PolicyCode code) : base (message, code) { }
}