using System;
class Program
{
    static void Main ()
    {
        Console.WriteLine("\nWelcome, dreckieee!\n");

        var bankAccount1 = new BankAccount("Alice", 500m);
        var bankAccount2 = new BankAccount("Bob", 100m);

        PrintBalance (bankAccount1, bankAccount2);

        try
        {
            decimal amount = 100m;
            Console.WriteLine($"\nDepositing {amount:C} to \"Alice\"...");
            bankAccount1.Deposit(amount);
            Console.WriteLine($"Successfully Deposited {amount:C} to Bank Account of \"Alice\"");
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Invalid Amount Error: {ex.Message}");
        }
        finally
        {
            PrintBalance (bankAccount1, bankAccount2);
        }

        try
        {
            decimal amount = -10m;
            Console.WriteLine($"\nDepositing {amount:C} to \"Alice\"...");
            bankAccount1.Deposit(amount);
            Console.WriteLine($"Successfully Deposited {amount:C} to Bank Account of \"Alice\"");
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Invalid Amount Error: {ex.Message}");
        }
        finally
        {
            PrintBalance (bankAccount1, bankAccount2);
        }
        

        try
        {
            decimal amount = 650m;
            Console.WriteLine($"\nWithdrawing {amount:C} from \"Alice\"...");
            bankAccount1.Withdraw(amount);
            Console.WriteLine($"Successfully Withdrew {amount:C} from Bank Account of \"Alice\"");
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Invalid Amount Error: {ex.Message}");
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Insufficient Funds Error: {ex.Message} Attempted: {ex.Amount:C}");
        }
        finally
        {
            PrintBalance (bankAccount1, bankAccount2);
        }

        try
        {
            decimal amount = 100m;
            Console.WriteLine($"\nWithdrawing {amount:C} from \"Alice\"...");
            bankAccount1.Withdraw(amount);
            Console.WriteLine($"Successfully Withdrew {amount:C} from Bank Account of \"Alice\"");
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Invalid Amount Error: {ex.Message}");
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Insufficient Funds Error: {ex.Message} Attempted: {ex.Amount:C}");
        }
        finally
        {
            PrintBalance (bankAccount1, bankAccount2);
        }
        


        try
        {
            decimal amount = 600m;
            Console.WriteLine($"\nTransferring {amount:C} to \"Bob\" from \"Alice\"...");
            bankAccount1.Transfer(amount, bankAccount2);
            Console.WriteLine($"Successfully Transferred {amount:C} from Bank Account of \"Alice\" to Bank Account of \"Bob\"");
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Invalid Amount Error: {ex.Message}");
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Insufficient Funds Error: {ex.Message} Attempted: {ex.Amount:C}");
        }
        finally
        {
            PrintBalance (bankAccount1, bankAccount2);
        }


        try
        {
            decimal amount = 500m;
            Console.WriteLine($"\nTransferring {amount:C} to \"Bob\" from \"Alice\"...");
            bankAccount1.Transfer(amount, bankAccount2);
            Console.WriteLine($"Successfully Transferred {amount:C} from Bank Account of \"Alice\" to Bank Account of \"Bob\"");
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Invalid Amount Error: {ex.Message}");
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Insufficient Funds Error: {ex.Message} Attempted: {ex.Amount:C}");
        }
        finally
        {
            PrintBalance (bankAccount1, bankAccount2);
        }
        
  
    }//end of Main method

    static void PrintBalance (BankAccount a, BankAccount b)
    {
        Console.WriteLine($"\n==================== BANK ACCOUNTS ====================");
        Console.WriteLine($">{a.Owner}");
        Console.WriteLine($"{a.Balance:C}");
        Console.WriteLine($"\n>{b.Owner}");
        Console.WriteLine($"{b.Balance:C}");
        Console.WriteLine($"=======================================================");        
    }
}//end of Program class