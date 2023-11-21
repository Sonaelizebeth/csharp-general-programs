using System;
namespace Generic{
    class StringDB{
        public List<string> Items=new List<string>();
        public void Create(string item){
            Items.Add(item);
        }
        public void Remove(string item){
            Items.Remove(item);
        }
        public void Display(){
            Console.WriteLine("List of Strings");
            Items.ForEach(x=>{
                Console.WriteLine(x);
            });
        }
    }
    class IntDB{
        public List<int> Items=new List<int>();
        public void Create(int item){
            Items.Add(item);
        }
        public void Remove(int item){
            Items.Remove(item);
        }
        public void Display(){
            Console.WriteLine("List of Integers");
            Items.ForEach(x=>{
                Console.WriteLine(x);
            });
        }
    }
    class GenericDB<T>{
        public List<T> Items=new List<T>();
        public void Create(T item){
            Items.Add(item);
        }
        public void Remove(T item){
            Items.Remove(item);
        }
        public void Display(){
            Console.WriteLine("List of "+ typeof(T).Name + "'s");
            Items.ForEach(x=>{
                Console.WriteLine(x);
            });
        }
    }
    class Generics{
        static void Main(string[] args){
            StringDB sdb = new StringDB();
            sdb.Create("Hello");
            sdb.Create("World");
            sdb.Display();

            IntDB idb = new IntDB();
            idb.Create(20);
            idb.Create(10);
            idb.Display();

            GenericDB<string> gdb = new GenericDB<string>();
            gdb.Create("Hi");
            gdb.Create("Minions");
            gdb.Display();

            GenericDB<int> gidb = new GenericDB<int>();
            gidb.Create(20);
            gidb.Create(10);
            gidb.Display();
        }
    }
}
