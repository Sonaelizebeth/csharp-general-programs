using System;
namespace Enum{
    class Enums{
        public enum Color{
            White,
            Red,
            Green=69 ,
            Blue,
            Maincolor = Red
        }
        static void Main(string[] args){
            Console.WriteLine(Color.White);
            Console.WriteLine((int)Color.White);
            Console.WriteLine(Color.Red);
            Console.WriteLine((int)Color.Red);
            Console.WriteLine((int)Color.Green);
            Console.WriteLine((int)Color.Blue);
            Console.WriteLine((int)Color.Maincolor);
        }
    }
}
