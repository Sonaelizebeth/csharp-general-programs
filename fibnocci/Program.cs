using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var fibonacciNumbers = new List<int> {1, 1};
           var previous=fibonacciNumbers[fibonacciNumbers.Count-1];
           var previous1=fibonacciNumbers[fibonacciNumbers.Count-2];
           fibonacciNumbers.Add(previous+previous1);
           foreach(var item in fibonacciNumbers){
            Console.WriteLine(item);
           }

            var fibonacciNumbers2 = new List<int> { 1, 1 };

            while (fibonacciNumbers2.Count < 20)
            {
                var previous2 = fibonacciNumbers2[fibonacciNumbers2.Count - 1];
                var previous3 = fibonacciNumbers2[fibonacciNumbers2.Count - 2];

                fibonacciNumbers2.Add(previous2 + previous3);
            }
            foreach (var items in fibonacciNumbers2)
            {
                Console.WriteLine(items);
            }
        }
    }
}