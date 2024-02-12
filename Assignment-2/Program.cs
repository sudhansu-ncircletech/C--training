using System;
using System.Collections.Generic;
using System.Linq;

class Employee(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
}

class Program
{
    static void Main()
    {
        // Create a list of employees
        List<Employee> employees =
        [
            new Employee("John", 30),
            new Employee("Jane", 25),
            new Employee("Bob", 35),
            new Employee("Alice", 28),
            new Employee("Eve", 40)
        ];

        // 1) Print names of employees with name length 4
        var employeeNames = employees.Where(e => e.Name.Length == 4).Select(e => e.Name);
        Console.WriteLine("Employees with name length 4:");
        foreach (var name in employeeNames)
        {
            Console.WriteLine(name);
        }

        // 2) Objects Condition and Ordering: Length == 4 and order by employees age
        var filteredAndOrdered = employees
            .Where(e => e.Name.Length == 4)
            .OrderBy(e => e.Age);

        Console.WriteLine("\nEmployees with name length 4, ordered by age:");
        foreach (var employee in filteredAndOrdered)
        {
            Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}");
        }

        // 3) Extracting Properties from Objects in a new collection
        var extractedProperties = employees
            .Select(e => new { e.Name, e.Age });

        Console.WriteLine("\nExtracted properties (Name and Age) in a new collection:");
        foreach (var property in extractedProperties)
        {
            Console.WriteLine($"Name: {property.Name}, Age: {property.Age}");
        }
    }
}

