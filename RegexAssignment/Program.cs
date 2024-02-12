using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string passwordPattern = GeneratePasswordPattern();
        Console.WriteLine("Password Pattern: " + passwordPattern);

        Console.Write("Enter a password: ");
        string userPassword = Console.ReadLine();

        if (ValidatePassword(userPassword, passwordPattern))
        {
            Console.WriteLine("Password is valid!");
        }
        else
        {
            Console.WriteLine("Password is invalid!");
        }
    }

    static string GeneratePasswordPattern()
    {
        // Define the conditions for the password pattern
        int minLength = 8;
        bool requireUppercase = true;
        bool requireLowercase = true;
        bool requireDigit = true;
        bool requireSpecialChar = true;

        // Build the regex pattern based on the conditions
        string pattern = "^";

        if (requireUppercase)
            pattern += "(?=.*[A-Z])";

        if (requireLowercase)
            pattern += "(?=.*[a-z])";

        if (requireDigit)
            pattern += "(?=.*\\d)";

        if (requireSpecialChar)
            pattern += "(?=.*[!@#$%^&*()_+\\-=[\\]{};':\",.<>/?])";

        pattern += ".{" + minLength + ",}$";

        return pattern;
    }

    static bool ValidatePassword(string password, string pattern)
    {
        return Regex.IsMatch(password, pattern);
    }
}
