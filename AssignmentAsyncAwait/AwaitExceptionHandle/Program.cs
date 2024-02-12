using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        try
        {
            await DoAsyncOperation();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }

    static async Task DoAsyncOperation()
    {
        // Simulate an asynchronous operation that may throw an exception
        await Task.Delay(1000);
        throw new Exception("Something went wrong!");
    }
}
