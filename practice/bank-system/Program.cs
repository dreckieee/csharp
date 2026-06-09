using System;

class Program
{
    static void Main ()
    {
        Console.WriteLine("\nWelcome, dreckieee!\n");
        
        var bankSystem = new Bank ();
        var alice = new BankAccount ("ALICE", 500m);
        var bob = new BankAccount ("BOB", 100m);
        var charlie = new BankAccount ("CHARLIE", 200m);
        bankSystem.Add(alice);
        bankSystem.Add(bob);
        bankSystem.Add(charlie);

        bankSystem.PrintAccounts();
        
        //valid deposit to alice
        try
        {
            string userName = "alice";
            decimal amount = 300m;
            string transaction = "deposit";

            Console.WriteLine($"Depositing {amount:C} to \"{userName}\" account...");
            bankSystem.ProcessTransaction(userName, amount, transaction);
            Console.WriteLine($"Transaction successful!");
        }

        catch (NullInputException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidTransactionTypeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (FindAccountNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }

        finally
        {
            bankSystem.PrintAccounts();
        }

        //invalid amount deposit to alice
        try
        {
            string userName = "alice";
            decimal amount = -900m;
            string transaction = "deposit";

            Console.WriteLine($"Depositing {amount:C} to \"{userName}\" account...");
            bankSystem.ProcessTransaction(userName, amount, transaction);
            Console.WriteLine($"Transaction successful!");
        }

        catch (NullInputException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidTransactionTypeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (FindAccountNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        
        finally
        {
            bankSystem.PrintAccounts();
        }

        //valid withdrawal from bob
        try
        {
            string userName = "bob";
            decimal amount = 50m;
            string transaction = "withdraw";

            Console.WriteLine($"Withdrawing {amount:C} from \"{userName}\" account...");
            bankSystem.ProcessTransaction(userName, amount, transaction);
            Console.WriteLine($"Transaction successful!");
        }

        catch (NullInputException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidTransactionTypeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (FindAccountNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        
        finally
        {
            bankSystem.PrintAccounts();
        }

        //Insufficient withdrawal from bob
        try
        {
            string userName = "bob";
            decimal amount = 100m;
            string transaction = "withdraw";

            Console.WriteLine($"Withdrawing {amount:C} from \"{userName}\" account...");
            bankSystem.ProcessTransaction(userName, amount, transaction);
            Console.WriteLine($"Transaction successful!");
        }

        catch (NullInputException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidTransactionTypeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (FindAccountNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        
        finally
        {
            bankSystem.PrintAccounts();
        }
        
        //Valid transfer from bob to alice
        try
        {
            string userName = "bob";
            decimal amount = 50m;
            string transaction = "transfer";
            string receivingAccount = "alice";

            Console.WriteLine($"Transferring {amount:C} from \"{userName}\" account to \"{receivingAccount}\"...");
            bankSystem.ProcessTransaction(userName, amount, transaction, receivingAccount);
            Console.WriteLine($"Transaction successful!");
        }

        catch (NullInputException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidTransactionTypeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (FindAccountNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        
        finally
        {
            bankSystem.PrintAccounts();
        }


        //Invalid transfer from bob to alice (no receiving account)
        try
        {
            string userName = "bob";
            decimal amount = 50m;
            string transaction = "transfer";

            Console.WriteLine($"Transferring {amount:C} from \"{userName}\" account to \"\"...");
            bankSystem.ProcessTransaction(userName, amount, transaction);
            Console.WriteLine($"Transaction successful!");
        }

        catch (NullInputException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidTransactionTypeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (FindAccountNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        
        finally
        {
            bankSystem.PrintAccounts();
        }
        
        //Invalid transaction type
        try
        {
            string userName = "charlie";
            decimal amount = 100m;
            string transaction = "Invest";

            Console.WriteLine($"Investing {amount:C} to \"{userName}\" account...");
            bankSystem.ProcessTransaction(userName, amount, transaction);
            Console.WriteLine($"Transaction successful!");
        }

        catch (NullInputException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidTransactionTypeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (FindAccountNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        
        finally
        {
            bankSystem.PrintAccounts();
        }
    }//end of Main method

}//end of Program class