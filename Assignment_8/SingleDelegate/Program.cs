using System;

public delegate void MyDelegate();

class Program
{
    static void Main()
    {
        MyDelegate myDelegate = new MyDelegate(PrintToConsole);
        myDelegate += PrintToFile;

        myDelegate.Invoke();
    }

    static void PrintToConsole()
    {
        Console.WriteLine("Printing to Console");
    }

    static void PrintToFile()
    {
        // Assuming you want to print to a file named "output.txt"
        System.IO.File.WriteAllText("output.txt", "Printing to File");
        Console.WriteLine("Printing to File");
    }
}

