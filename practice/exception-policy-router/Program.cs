class Program
{
    static void Main()
    {
        Console.WriteLine("========================= EXCEPTION POLICY ROUTER =========================");
        var requests = new List<Request>();

        var request = new Request ("User dreck is denied of access to the system", RequestType.Access);
        requests.Add(request);

        request = new Request ("User dreck's login credentials to the system has expired", RequestType.Access);
        requests.Add(request);

        request = new Request ("User dreck's storage has hit the limit", RequestType.Quota);
        requests.Add(request);

        request = new Request ("User dreck's bandwidth has hit the limit", RequestType.Quota);
        requests.Add(request);

        request = new Request("User dreck submitted an unrecognized request", RequestType.Access);
        requests.Add(request);

        Console.WriteLine();
        foreach (Request r in requests)
        {
            try
            {
                r.Process();
            }
            catch (AccessException ex) when (ex.Code == PolicyCode.Access001)
            {
                Console.WriteLine($"> {ex.Code} PERMISSION MISSING -- {ex.Message}\n");
            }
            catch (AccessException ex) when (ex.Code == PolicyCode.Access002)
            {
                Console.WriteLine($"> {ex.Code} CREDENTIALS EXPIRED -- {ex.Message}\n");
            }
            catch (QuotaException ex) when (ex.Code == PolicyCode.Quota001)
            {
                Console.WriteLine($"> {ex.Code} STORAGE LIMIT -- {ex.Message}\n");
            }
            catch (QuotaException ex) when (ex.Code == PolicyCode.Quota002)
            {
                Console.WriteLine($"> {ex.Code} BANDWIDTH -- {ex.Message}\n");
            }
            catch (PolicyException ex)
            {
                Console.WriteLine($"> {ex.Code} UNEXPECTED ERROR -- {ex.Message}\n");
            }
        }
    }//end of Main method
}//end of Program class