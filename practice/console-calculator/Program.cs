class Program
{
    static void Main ()
    {
        
        Console.WriteLine("\n=================== CALCULATOR ===================\n");
        var calculator = new Calculator();
        while(true)
        {
            Console.WriteLine("1 -- Addition\n2 -- Subtraction\n3 -- Multiplication\n4 -- Division\n5 -- Clear\n6 -- Exit Calculator");
            int command = PickCommand("Which mathematical operation would you like to execute (refer commands above): ",1,6);

            //Addition
            if(command == 1)
            {
                SetOperands(calculator);
                calculator.Addition();
                calculator.DisplayOutput();
            }

            //Subtraction
            else if (command == 2)
            {
                SetOperands(calculator);
                calculator.Subtraction();
                calculator.DisplayOutput();
            }

            //Multiplication
            else if (command == 3)
            {
                SetOperands(calculator);
                calculator.Multiplication();
                calculator.DisplayOutput();
            }

            //Division
            else if (command == 4)
            {
                try
                {
                    SetOperands(calculator);
                    calculator.Division();
                    calculator.DisplayOutput();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }

            //Clear
            else if (command == 5)
            {
                calculator.Clear();
                Console.WriteLine("\nCalculator reset!");
            }

            //Exit
            else if (command == 6)
            {
                Console.WriteLine("\nEnding program..\n");
                break;
            }
        }

        
    }//end of Main method

    public static int PickCommand(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            if(int.TryParse(Console.ReadLine(), out int result))
            {
                if (result >= min && result <= max)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Invalid. Must be between {min} and {max}. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid. Enter an integer number. Try again.");
            }
        }
    }

    public static decimal ReadDecimal(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (decimal.TryParse(Console.ReadLine(), out decimal result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid. Enter a decimal number. Try again.");
            }
        }
    }//end of ReadDecimal method


    public static void SetOperands (Calculator calculator)
    {
        if (calculator.IsFirstOperation)
        {
            decimal operand1 = ReadDecimal("Enter Operand 1: ");
            calculator.SetOperand1(operand1);   
        }
        else
        {
            calculator.SetOperand1(calculator.Output); 
        }
        decimal operand2 = ReadDecimal("Enter Operand 2: ");
        calculator.SetOperand2(operand2);
    }

}