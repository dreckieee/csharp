public class Calculator
{
    public bool IsFirstOperation {get; private set;} = true;
    public decimal FirstNumber {get; private set;}
    public decimal SecondNumber {get; private set;}
    public decimal Output {get; private set;}
    

    public void SetOperand1(decimal input)
    {
        FirstNumber = input;
    }
    

    public void SetOperand2(decimal input)
    {
        SecondNumber = input;
    }

    public void Addition ()
    {
        Output = FirstNumber + SecondNumber;
        IsFirstOperation = false;
    }
    public void Subtraction ()
    {
        Output = FirstNumber - SecondNumber;
        IsFirstOperation = false;
    }
    public void Multiplication ()
    {
        Output = FirstNumber * SecondNumber;
        IsFirstOperation = false;
    }
    public void Division ()
    {
        if (SecondNumber == 0)
        {
            throw new ArgumentException("\nYou cannot divide by zero(0).",nameof(SecondNumber));
        }

        Output = FirstNumber / SecondNumber;
        IsFirstOperation = false;
    }

    public void Clear()
    {
        IsFirstOperation = true;
        FirstNumber = 0;
        SecondNumber = 0;
        Output = 0;
    }

    public void DisplayOutput ()
    {
        Console.WriteLine($"\nResult: {Output}\n");
    }

}