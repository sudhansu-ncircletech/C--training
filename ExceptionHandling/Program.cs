using System;
using System.IO;
using System.Net;
using System.Collections.ObjectModel;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Divide by zero exception");
            Console.WriteLine("2. Index out of range exception");
            Console.WriteLine("3. Format exception");
            Console.WriteLine("4. Custom exception");
            Console.WriteLine("5. Argument null exception");
            Console.WriteLine("6. Null reference exception");
            Console.WriteLine("7. Invalid operation exception");
            Console.WriteLine("8. File not found exception");
            Console.WriteLine("9. IO exception");
            Console.WriteLine("10. Not supported exception");
            Console.WriteLine("11. Overflow exception");
            Console.WriteLine("12. Array type mismatch exception");
            Console.WriteLine("13. Web exception");
            Console.WriteLine("14. Exit");
            Console.Write("Enter your choice: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DivideByZeroExceptionExample();
                    break;
                case "2":
                    IndexOutOfRangeExceptionExample();
                    break;
                case "3":
                    FormatExceptionExample();
                    break;
                case "4":
                    CustomExceptionExample();
                    break;
                case "5":
                    ArgumentNullExceptionExample();
                    break;
                case "6":
                    NullReferenceExceptionExample();
                    break;
                case "7":
                    InvalidOperationExceptionExample();
                    break;
                case "8":
                    FileNotFoundExceptionExample();
                    break;
                case "9":
                    IOExceptionExample();
                    break;
                case "10":
                    NotSupportedExceptionExample();
                    break;
                case "11":
                    OverflowExceptionExample();
                    break;
                case "12":
                    ArrayTypeMismatchExceptionExample();
                    break;
                case "13":
                    WebExceptionExample();
                    break;
                case "14":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void DivideByZeroExceptionExample()
    {
        try
        {
            int numerator = 10;
            int denominator = 0;
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static void IndexOutOfRangeExceptionExample()
    {
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.Write("Enter an index to access the array: ");
            int index = int.Parse(Console.ReadLine());
            if (index != null)
            {
                int value = numbers[index];
                Console.WriteLine("Value at index " + index + ": " + value);
            }

        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static void FormatExceptionExample()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static void CustomExceptionExample()
    {
        try
        {
            Console.Write("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new CustomException("Negative numbers are not allowed.");
            }

            Console.WriteLine("You entered a positive number: " + number);
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
    }
    static void ArgumentNullExceptionExample()
    {
        try
        {
            string value = null;
            Console.WriteLine(value.Length);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static void NullReferenceExceptionExample()
    {
        try
        {
            string value = null;
            Console.WriteLine(value.ToUpper());
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static void InvalidOperationExceptionExample()
    {
        try
        {
            var list = new System.Collections.ArrayList();
            list.Add("item1");
            list.Add("item2");
            list.Remove("item3"); // item3 is not present
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }
    static void FileNotFoundExceptionExample()
    {
        try
        {
            string filePath = "nonexistentfile.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static void IOExceptionExample()
    {
        try
        {
            // Try to open a file that is currently in use by another process
            using (FileStream fs = new FileStream("lockedFile.txt", FileMode.OpenOrCreate))
            {
                // Simulate a lock on the file
                Console.WriteLine("File is locked. Cannot perform the operation.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static void NotSupportedExceptionExample()
    {
        try
        {
            // Attempting to modify a read-only collection
            var readOnlyCollection = new ReadOnlyCollection<int>(new List<int>());
            var list = (List<int>)readOnlyCollection.GetType().GetProperty("Items").GetValue(readOnlyCollection, null);
            list.Add(5); // Modifying the underlying list
            Console.WriteLine("Added element to read-only collection");
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static void OverflowExceptionExample()
    {
        try
        {
            checked
            {
                int maxIntValue = int.MaxValue;
                int result = maxIntValue + 1; // Causes overflow
                Console.WriteLine(result);
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static void ArrayTypeMismatchExceptionExample()
    {
        try
        {
            object[] objArray = new string[5];
            objArray[0] = 10; // Causes ArrayTypeMismatchException
        }
        catch (ArrayTypeMismatchException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static void WebExceptionExample()
    {
        try
        {
            // Trying to access a non-existent website
            var request = WebRequest.Create("http://nonexistentwebsite.com");
            using (var response = request.GetResponse())
            {
                // Code to handle the response
            }
        }
        catch (WebException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}

