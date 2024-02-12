using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public enum Dept
{
    IT,
    HR,
    Payroll,
    Engineering,
    Admin,
    Sales
}

public enum Gender
{
    Male,
    Female
}

public class Emp
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Dept Department { get; set; }
    public Gender Gender { get; set; }
    public string? Country { get; set; }
    public int Salary { get; set; }
    public DateTime DOB { get; set; }
}

class Program
{
    static void Main()
    {
        // Store 100 employee data manually and create a list
        List<Emp> employees =
        [
        new Emp { Id = 1, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 2, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 3, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 4, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 5, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 6, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 7, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 8, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 9, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 10, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 11, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 12, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 13, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 14, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 15, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 16, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 17, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 18, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 19, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 20, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 21, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 22, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 23, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 24, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 25, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 26, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 27, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 28, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 29, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 30, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 31, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 32, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 33, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 34, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 35, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 36, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 37, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 38, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 39, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 40, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 41, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 42, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 43, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 44, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 45, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 46, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 47, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 48, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 49, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 50, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 51, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 52, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 53, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 54, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 55, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 56, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 57, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 58, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 59, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 60, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 61, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 62, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 63, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 64, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 65, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 66, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 67, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 68, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 69, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 70, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
        new Emp { Id = 71, FirstName = "John", LastName = "Doe", Department = Dept.IT, Gender = Gender.Male, Country = "USA", Salary = 80000, DOB = new DateTime(1990, 5, 15) },
        new Emp { Id = 72, FirstName = "Jane", LastName = "Smith", Department = Dept.HR, Gender = Gender.Female, Country = "Canada", Salary = 75000, DOB = new DateTime(1985, 8, 22) },
        new Emp { Id = 73, FirstName = "Bob", LastName = "Johnson", Department = Dept.Engineering, Gender = Gender.Male, Country = "UK", Salary = 90000, DOB = new DateTime(1988, 3, 10) },
        new Emp { Id = 74, FirstName = "Alice", LastName = "Williams", Department = Dept.Sales, Gender = Gender.Female, Country = "Australia", Salary = 82000, DOB = new DateTime(1992, 7, 5) },
        new Emp { Id = 75, FirstName = "Charlie", LastName = "Brown", Department = Dept.Admin, Gender = Gender.Male, Country = "Germany", Salary = 78000, DOB = new DateTime(1995, 12, 18) },
    ];

        // Find the max and min salary of male employees
        var maxSalaryMale = employees.Where(emp => emp.Gender == Gender.Male).Max(emp => emp.Salary);
        var minSalaryMale = employees.Where(emp => emp.Gender == Gender.Male).Min(emp => emp.Salary);

        // Display employee details with max salary for males
        Console.WriteLine("Details of employee with max salary (Male):");
        DisplayEmployeeDetails(employees.First(emp => emp.Gender == Gender.Male && emp.Salary == maxSalaryMale));

        // Display employee details with min salary for males
        Console.WriteLine("Details of employee with min salary (Male):");
        DisplayEmployeeDetails(employees.First(emp => emp.Gender == Gender.Male && emp.Salary == minSalaryMale));

        // Create a new list for employees with { ID, FullName, and Gender only }
        var empListWithIdFullNameGender = employees.Select(emp => new
        {
            ID = emp.Id,
            FullName = $"{emp.FirstName} {emp.LastName}",
            Gender = emp.Gender
        }).ToList();

        // Display the new list for employees with { ID, FullName, and Gender only }
        Console.WriteLine("\nNew list for employees with { ID, FullName, and Gender only }:");
        foreach (var emp in empListWithIdFullNameGender)
        {
            Console.WriteLine($"ID: {emp.ID}, FullName: {emp.FullName}, Gender: {emp.Gender}");
        }

        // Create a new list for only female employees
        var femaleEmployees = employees.Where(emp => emp.Gender == Gender.Female).ToList();

        // Display the list of female employees
        Console.WriteLine("\nList of female employees:");
        foreach (var emp in femaleEmployees)
        {
            DisplayEmployeeDetails(emp);
        }

        // Sort employee list based on Salary and Gender
        var sortedEmployees = employees.OrderBy(emp => emp.Salary).ThenBy(emp => emp.Gender).ToList();

        // Display the sorted list of employees
        Console.WriteLine("\nSorted employee list based on Salary and Gender:");
        foreach (var emp in sortedEmployees)
        {
            DisplayEmployeeDetails(emp);
        }
        string relativePath = "employees.json";

        // Combine the relative path with the current working directory
        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), relativePath);
        // Export data in All employee data in json file
        string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
       try
        {
            // Write the JSON to the file using the full path
            File.WriteAllText(fullPath, json);
            Console.WriteLine($"Data exported to: {fullPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static void DisplayEmployeeDetails(Emp emp)
    {
        Console.WriteLine($"ID: {emp.Id}, Name: {emp.FirstName} {emp.LastName}, DOB: {emp.DOB}, Salary: {emp.Salary}, Gender: {emp.Gender}");
    }
}
