public class BankAccount
{
    public string Owner {get; private set;}
    public decimal Balance {get; private set;}
    public BankAccount (string owner, decimal balance)
    {
        Owner = owner.ToUpper();
        Balance = balance;
    }
    public void Deposit (decimal amount)
    {
        if (amount <= 0)
        {
            throw new InvalidAmountException("Deposits are not possible for 0.00 or less.");
        }
        Balance += amount;
    }

    public void Withdraw (decimal amount)
    {
        if (amount <= 0) 
        {
            throw new InvalidAmountException("Withdrawals are not possible for 0.00 or less.");
        }        
        if (amount > Balance) 
        {
            throw new InsufficientFundsException($"A withdrawal of {amount:C} is not possible from your balance of {Balance:C}", amount);
        }
        Balance -= amount;
    }

    public void Transfer (decimal amount, BankAccount receivingAccount)
    {
        Withdraw(amount);
        receivingAccount.Deposit(amount);
    }
}