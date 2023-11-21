using System;
namespace Access{
    class Student{
        public string name ="Kevin";
        private int age = 29;
        protected string location = "Kochi";
        public int GetAge(){
            return age;
        }

    }
    class College : Student{
        public string GetLocation(){
            return location;
        }
    }
    class AccessModifier{
        static void Main(string[] args){
            Student s = new Student();
            Console.WriteLine(s.name);
            //Console.WriteLine(s.age); - not possible
            Console.WriteLine(s.GetAge());
            //Console.WriteLine(s.location); - not possible
            //Console.WriteLine(s.GetLocation()); - not possible
            College c = new College();
            Console.WriteLine(c.GetLocation());
        }
    }
}
