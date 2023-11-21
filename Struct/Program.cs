using System;
namespace Struct{
    class Structs{
        struct Student{
            public string name;
            public int marks;
            public Student(string name,int marks){
                this.name=name;
                this.marks=marks;
            }
            public void Display(){
                Console.WriteLine("Name: {0},marks: {1}",name,marks);
            }
        }
        static void Main(String[] args){
            Student s1;
            s1.name="Krishna";
            s1.marks=70;
            s1.Display();
        }
    }
}
