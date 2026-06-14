public class Request
{
    public string Description {get; private set;}
    public RequestType Type {get; private set;}
    public Request (string description, RequestType type)
    {
        Description = description;
        Type = type;
    }
    public void Process ()
    {
        if (Type == RequestType.Access && Description.Contains("Denied", StringComparison.OrdinalIgnoreCase))
        {
            throw new AccessException ($"Access Request Failed: {Description}", PolicyCode.Access001);
        }
        else if (Type == RequestType.Access && Description.Contains("expired", StringComparison.OrdinalIgnoreCase))
        {
            throw new AccessException ($"Access Request Failed: {Description}", PolicyCode.Access002);
        }
        else if (Type == RequestType.Quota && Description.Contains("storage", StringComparison.OrdinalIgnoreCase))
        {
            throw new QuotaException ($"Quota Request Failed: {Description}", PolicyCode.Quota001);
        }
        else if (Type == RequestType.Quota && Description.Contains("bandwidth", StringComparison.OrdinalIgnoreCase))
        {
            throw new QuotaException ($"Quota Request Failed: {Description}", PolicyCode.Quota002);
        }
        else
        {
            throw new PolicyException($"Unrecognized request: {Description}", PolicyCode.Unknown);
        }
    }
}