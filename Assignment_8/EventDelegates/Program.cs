using System;

public class Calculator
{
    public event EventHandler<int> Addition;
    public event EventHandler<int> Subtraction;

    public void PerformOperations(int a, int b)
    {
        OnAddition(a, b);
        OnSubtraction(a, b);
    }

    protected virtual void OnAddition(int a, int b)
    {
        Addition?.Invoke(this, a + b);
    }

    protected virtual void OnSubtraction(int a, int b)
    {
        Subtraction?.Invoke(this, a - b);
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        calculator.Addition += (sender, result) =>
        {
            Console.WriteLine($"Addition Result: {result}");
        };

        calculator.Subtraction += (sender, result) =>
        {
            Console.WriteLine($"Subtraction Result: {result}");
        };

        calculator.PerformOperations(10, 5);
    }
}

