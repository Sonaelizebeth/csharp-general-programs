using System; 
namespace AnonymousMethod{
    class AnonymousMethods{
        public delegate int SumDelegate(int x, int y);
        static void Main(string[] args){
            SumDelegate sd = new SumDelegate(Sum);
            Console.WriteLine(sd(100,200));
            //or
            // SumDelegate sd1 = delegate(int x,int y) { return x+y;};
            // Console.WriteLine(sd(100,200));
        }
        static int Sum(int x,int y){
            return x+y;
        }
    }
}
