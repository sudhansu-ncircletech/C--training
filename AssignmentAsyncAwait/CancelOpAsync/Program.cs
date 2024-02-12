
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        // Start an asynchronous operation with cancellation support
        Task operationTask = DoAsyncOperation(cancellationTokenSource.Token);

        // Simulate cancellation after some time
        await Task.Delay(3000);
        cancellationTokenSource.Cancel();

        try
        {
            // Await the completion of the operation
            await operationTask;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operation was canceled!");
        }
    }

    static async Task DoAsyncOperation(CancellationToken cancellationToken)
    {
        try
        {
            // Simulate an asynchronous operation that takes time
            for (int i = 0; i < 10; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    // Check for cancellation request before each iteration
                    cancellationToken.ThrowIfCancellationRequested();
                }

                await Task.Delay(600);
                Console.WriteLine($"Iteration {i + 1}");
            }
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operation was canceled during execution!");
            // Handle any cleanup or specific actions upon cancellation
        }
    }
}
