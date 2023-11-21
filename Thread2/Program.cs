//Create a task using an action delegate and passes an argument.
using System.Threading.Tasks;
var action = new Action<int>((n) => // takes an integer parameter n
{
    for (int i = 0; i < n; i++)
    {
        Task.Delay(5000);
        Console.WriteLine($"{i}");
    }
});

Task myTask = new Task(() => { action(500); }); //executes the delegate code 500 times with delay of 5 seconds between 
                                                //each iteration
myTask.Start();

myTask.Wait();