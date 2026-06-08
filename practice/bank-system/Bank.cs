public class Bank
{
    private List<BankAccount> BankAccounts {get;} = new();

    public void Add (BankAccount newAccount)
    {
        BankAccounts.Add(newAccount);
    }

    public BankAccount FindAccount (string ownerName)
    {
        if (string.IsNullOrWhiteSpace(ownerName)) 
        {
            throw new NullInputException("Cannot be empty");
        }
        foreach (BankAccount account in BankAccounts)
        {
            if (account.Owner == ownerName) 
            {
                return account;
            }
        }
        throw new FindAccountNotFoundException($"Account with the NAME \"{ownerName}\" is not found!", ownerName);
    }
    public void ProcessTransaction (string owner, decimal amount, string type)
    {
        BankAccount found = FindAccount(owner);
        if (string.IsNullOrWhiteSpace(type))
        {
            throw new NullInputException("Cannot be empty");
        }
        else if (type.ToUpper() == "DEPOSIT")
        {
            found.Deposit(amount);
        }
        else if (type.ToUpper() == "WITHDRAW")
        {
            found.Withdraw(amount);
        }
        else
        {
            throw new InvalidTransactionTypeException($"Transaction type \"{type}\" is not recognized!", type);
        }
    }

    public void ProcessTransaction (string owner, decimal amount, string type, BankAccount receivingAccount)
    {
        BankAccount found = FindAccount(owner);
        if (string.IsNullOrWhiteSpace(type))
        {
            throw new NullInputException("Cannot be empty");
        }
        else if (type.ToUpper() == "DEPOSIT")
        {
            found.Deposit(amount);
        }
        else if (type.ToUpper() == "WITHDRAW")
        {
            found.Withdraw(amount);
        }
        else if (type.ToUpper() == "TRANSFER")
        {
            found.Transfer(amount, receivingAccount);
        }
        else
        {
            throw new InvalidTransactionTypeException($"Transaction type \"{type}\" is not recognized!", type);
        }
    }


}