using System;
using System.IO;
namespace ExceptionHandle{
    class ExceptionHandling{
        static void Main(string[] args){
            try{
                Console.Write("Enter the first number to divide: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number to divide: ");
                int number2 = int.Parse(Console.ReadLine());
                int divide = number1/number2;
                Console.WriteLine($"Answer:{divide} ");
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("Final block");
            }
        }
    }
}