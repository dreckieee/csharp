public class Bank
{
    private List<BankAccount> BankAccounts {get;} = new();

    public void Add (BankAccount newAccount)
    {
        BankAccounts.Add(newAccount);
    }//end of Add method

    public BankAccount FindAccount (string ownerName)
    {
        if (string.IsNullOrWhiteSpace(ownerName)) 
        {
            throw new NullInputException("Search is not possible with empty input.");
        }
        foreach (BankAccount account in BankAccounts)
        {
            if (account.Owner.Equals(ownerName, StringComparison.OrdinalIgnoreCase)) 
            {
                return account; 
            }
        }
        throw new FindAccountNotFoundException($"Account with the NAME \"{ownerName}\" is not found.", ownerName);
    }//end of FindAccount method

    public void ProcessTransaction (string owner, decimal amount, string type, string receivingAccount = "")
    {
        try
        {
            BankAccount found = FindAccount(owner);
            if (type.ToUpper() == "DEPOSIT")
            {
                found.Deposit(amount);
            }
            else if (type.ToUpper() == "WITHDRAW")
            {
                found.Withdraw(amount);
            }
            else if (type.ToUpper() == "TRANSFER")
            {
                if (string.IsNullOrWhiteSpace(receivingAccount))
                {
                    throw new NullInputException("No detected receiving account for \"TRANSFER\" transaction type.");
                }
                found.Transfer(amount, FindAccount(receivingAccount));
            }
            else
            {
                throw new InvalidTransactionTypeException($"Choose between \"DEPOSIT\", \"WITHDRAW\", \"TRANSFER\"");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[LOG] Transaction failed: {ex.Message}");
            throw;
        }
    }//end of ProcessTransaction method

    public void PrintAccounts ()
    {
        Console.WriteLine($"\n==================== BANK ACCOUNTS ====================\n");
        foreach (BankAccount account in BankAccounts)
        {
            Console.Write($">Name: {account.Owner}".PadRight(25));
            Console.Write($"Balance: {account.Balance:C}\n");            
        }
        Console.WriteLine($"\n=======================================================\n");        
    }    

}