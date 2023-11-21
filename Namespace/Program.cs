// using System;
// namespace NamespaceOne{
//     class A{
//         public void MyMethod(){
//             Console.WriteLine("Message from namespace one class A");
//         }
//     }
// }
// namespace NamespaceTwo{
//     class A{
//         public void MyMethod(){
//             Console.WriteLine("Message from namespace two class A");
//         }
//     }
// }
// namespace Namespace{
//     class Namespaces{
//         static void Main(string[] args){
//             NamespaceOne.A a = new NamespaceOne.A();
//             a.MyMethod();
//             NamespaceTwo.A b = new NamespaceTwo.A();
//             b.MyMethod();
//         }
//     }
// }



using System;
using NamespaceOne;
using Outer.NamespaceTwo;
namespace NamespaceOne{
    class A{
        public void MyMethod(){
            Console.WriteLine("Message from namespace one class A");
        }
    }
}
namespace Outer{
    namespace NamespaceTwo{
        class B{
            public void MyMethod(){
                Console.WriteLine("Message from namespace two class B");
            }
        }
    }
}
namespace Namespace{
    class Namespaces{
        static void Main(string[] args){
            A a = new A();
            a.MyMethod();
            B b = new B();
            b.MyMethod();
        }
    }
}