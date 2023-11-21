using System;
namespace LambdaExp{
    class LambdaExpression{
        static void Main(string[] args){
            Console.WriteLine(LambdaExpression.Sum(10,20));
            //Expression lambda
            Func<int,int,int> ExSum = (x,y) =>x+y;
            Console.WriteLine(ExSum(25,20));
            //Statement lambda
            Func<int,int,int> Stsum = (x,y)=>
            {
                var sum =x+y;
                return sum;
            };
            Console.WriteLine(Stsum(39,12));

        }
        static int Sum(int x,int y){
            return x+y;
        }
    }
}
