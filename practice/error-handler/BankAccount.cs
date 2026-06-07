public class BankAccount
{
    public string Owner {get; private set;}
    public decimal Balance {get; private set;}
    public BankAccount (string owner, decimal balance)
    {
        Owner = owner;
        Balance = balance;
    }
    public void Deposit (decimal amount)
    {
        if (amount <= 0)
        {
            throw new InvalidAmountException("Invalid amount. Enter amount greater than 0.");
        }
        Balance += amount;
    }

    public void Withdraw (decimal amount)
    {
        if (amount <= 0) 
        {
            throw new InvalidAmountException("Invalid amount. Enter amount greater than 0.");
        }        
        if (amount > Balance) 
        {
            throw new InsufficientFundsException($"Insufficient funds. You only have {Balance:C} left.", amount);
        }
        Balance -= amount;
    }

    public void Transfer (decimal amount, BankAccount receivingAccount)
    {
        Withdraw(amount);
        receivingAccount.Deposit(amount);
    }
}