using System;
namespace GetSet{
    class Student{
 
        public string name;
        private string gender;
        public Student(string cName,string cGender){
            name=cName;
            gender=cGender;
        }
        public string Gender{
            get {return gender;}
            set{
                if(value=="Male" || value =="Female" || value == "Other"){
                    gender = value;
                }
                else{
                    throw new ArgumentNullException("Invalid value supplied");
                }
            }
        }
    }
    class GetterSetter{
        static void Main(string[] args){
            Student s = new Student("Krishna","Female");
            Console.WriteLine(s.Gender);
        }
    }
}
