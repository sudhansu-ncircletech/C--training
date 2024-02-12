using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Scenario 1: Displaying a Dialog
        ShowDialog("This is a message.");
        Console.ReadLine(); // To keep the console application running for demonstration purposes.

        // Scenario 2: Aborting a Long Operation
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = cancellationTokenSource.Token;

        Task operationTask = Task.Run(() => LongOperation(cancellationToken));

        // Wait for 5 seconds, then cancel the operation if it's still running
        if (!operationTask.Wait(5000, cancellationToken))
        {
            cancellationTokenSource.Cancel();
            Console.WriteLine("Operation canceled due to timeout.");
        }
        else
        {
            Console.WriteLine("Operation completed within 5 seconds.");
        }

        // Scenario 3: Showing an "In Progress" Popup
        ShowInProgressPopup();
        Console.ReadLine(); // To keep the console application running for demonstration purposes.
    }

    static void ShowDialog(string message)
    {
        bool userClosedManually = false;

        // Show dialog in a separate thread
        Task.Run(() =>
        {
            Console.WriteLine(message);
            Thread.Sleep(15000); // Simulate a 15-second timeout
            if (!userClosedManually)
            {
                CloseDialog();
            }
        });

        // Simulate user closing the dialog manually
        Console.WriteLine("Press Enter to close the dialog manually.");
        Console.ReadLine();
        userClosedManually = true;
        CloseDialog();
    }

    static void CloseDialog()
    {
        Console.WriteLine("Closing dialog.");
    }

    static void LongOperation(CancellationToken cancellationToken)
    {
        try
        {
            // Simulate a long operation
            Thread.Sleep(8000);

            // Check for cancellation request
            cancellationToken.ThrowIfCancellationRequested();

            Console.WriteLine("Operation completed.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operation canceled.");
        }
    }

    static void ShowInProgressPopup()
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = cancellationTokenSource.Token;

        Task operationTask = Task.Run(() =>
        {
            Thread.Sleep(400); // Simulate a long operation (less than a second)
        }, cancellationToken);

        // Show the "In Progress" popup after 1 second if the operation is still running
        Task.Delay(1000).ContinueWith(_ =>
        {
            if (!operationTask.IsCompleted)
            {
                ShowPopup("In Progress");
            }
            else
            {
                Console.WriteLine("Operation completed within 1 second. No need to show the popup.");
            }
        });

        operationTask.Wait(cancellationToken);
    }

    static void ShowPopup(string message)
    {
        Console.WriteLine(message + " popup shown.");
    }
}
