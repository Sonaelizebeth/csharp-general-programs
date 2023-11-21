using System.Threading.Tasks; //TPL is a set of APIs using the System.Threading and System.Threading.Task namespace.
//Create a task using an action void delegate.

//defines the action delegate
var action = new Action(() => //=> defines the lambda expression, a mini method that takes no parameters
{
    Console.WriteLine("Hello");
    Task.Delay(5000); //waits for 5 seconds
    Console.WriteLine("Hello Task World");
});

//Creating a task and starting it
Task myTask = new Task(action); //passes the delegate to myTask
myTask.Start(); //starts the execution of delegate in separate thread

myTask.Wait(); // waiting for the task to complete, this blocks the current thread until myTask finishes executing.nm b 