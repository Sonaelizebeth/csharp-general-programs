using System;
using System.Collections.Generic;
namespace MyApp{
    class Task{
        static void Main(string[] args){

            LinkedList<int> list1 = new LinkedList<int>();
            Console.WriteLine("Enter the number of numbers:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers:");
            for(int i=1;i<=n;i++){
                int m = Convert.ToInt32(Console.ReadLine());
                list1.AddLast(m);
            }
            foreach (int j in list1)
            {
                Console.WriteLine(j);
            }
            
        }
    }
}
