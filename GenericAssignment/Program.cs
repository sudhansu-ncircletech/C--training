using System;

//Using Generic
class Program
{
    static void PrintArray<T>(T[] arr)
    {
        foreach (var element in arr)
        {
            Console.WriteLine(element);
        } 
    }

    static void Main()
    {
        int[] intArray = { 1, 2, 3 };
        string[] stringArray = { "Hello", "World" };

        PrintArray(intArray);
        PrintArray(stringArray);
    }
}


//Method Overloading

// class Program
// {
//     static void PrintArray(int[] arr)
//     {
//         foreach (var element in arr)
//         {
//             Console.WriteLine(element);
//         }
//     }

//     static void PrintArray(string[] arr)
//     {
//         foreach (var element in arr)
//         {
//             Console.WriteLine(element);
//         }
//     }

//     static void Main()
//     {
//         int[] intArray = { 1, 2, 3 };
//         string[] stringArray = { "Hello", "World" };

//         PrintArray(intArray);
//         PrintArray(stringArray);
//     }
// }

