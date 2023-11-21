using System;
namespace IEnumerable{
    class IEnumerableAndIEnumerator{
        static void Main(string[] args){
            List<int> nums = new List<int>() {23,40,29,1,45,5};
            nums.Add(600);
            // foreach (var item in nums)
            // {
            //      Console.WriteLine(item);
            // }
            //or
            // IEnumerable<int> enumerables = nums;
            // foreach(var item in enumerables){
            //     Console.WriteLine(item);
            // }

            // IEnumerable<int> enumerables = nums;
            // var enumerator1 = enumerables.GetEnumerator();
            // while (enumerator1.MoveNext())
            // {
            //     Console.WriteLine(enumerator1.Current);
            // }

            IEnumerable<int> enumerables = nums;
            IEnumerator<int> enumerator1 = enumerables.GetEnumerator();
            IEnumerator<int> enumerator2 = enumerables.GetEnumerator();
            enumerator1.MoveNext();
            enumerator1.MoveNext();
            while (enumerator1.MoveNext())
            {
                Console.WriteLine(enumerator1.Current);
            }
            Console.WriteLine("Enumerator 1 after reset");
            enumerator1.Reset();
            while (enumerator1.MoveNext())
            {
                Console.WriteLine(enumerator1.Current);
            }
            Console.WriteLine("Enumerator 2");
            while (enumerator2.MoveNext())
            {
                Console.WriteLine(enumerator2.Current);
            }
        }
    }
}

