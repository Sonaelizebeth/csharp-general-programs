using System.Threading.Tasks;
//Create a task using a func delegate.
var func = new Func<int, int>((n) =>
{
    int total = 0;

    for (int i = 0; i < n; i++)
    {
        Task.Delay(5000);

        total += (int)Math.Pow(i, 2);

        Console.WriteLine($"{total}");
    }

    return total;
});

Task<int> myTask = new Task<int>(() => { return func(50); });
myTask.Start();

myTask.Wait();

Console.WriteLine($"My total {myTask.Result}");
