using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=7;
            int b=2;
            int c=5;
            bool some=a+b+c>10;
            if(some){
                Console.WriteLine("Greater than 10");
            }
            // if(a+b+c>10){
            //     Console.WriteLine("Greater than 10");
            // }
        }
    }
}
