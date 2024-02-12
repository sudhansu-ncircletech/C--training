using System;

public delegate void MyDelegate();

class Program
{
    static void Main()
    {
        MyDelegate firstDelegate = new MyDelegate(PrintHello);
        MyDelegate secondDelegate = new MyDelegate(PrintWelcome);

        MyDelegate multiDelegate = firstDelegate + secondDelegate;

        Console.WriteLine("First Delegate:");
        firstDelegate.Invoke();

        Console.WriteLine("\nSecond Delegate:");
        secondDelegate.Invoke();

        Console.WriteLine("\nMultiDelegate:");
        multiDelegate.Invoke();
    }

    static void PrintHello()
    {
        Console.WriteLine("Hello");
    }

    static void PrintWelcome()
    {
        Console.WriteLine("Welcome");
    }
}

