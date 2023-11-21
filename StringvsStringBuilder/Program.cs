using System;
using System.Runtime.InteropServices;
using System.Text;
namespace StringVsStringBuilder{
    class StringvsStringBuilder{
        static void Main(string[] args){
            //------------------String------------------
            string msg = "Hello World";
            //to get actual memory location
            GCHandle gch = GCHandle.Alloc(msg,GCHandleType.Pinned);
            //get memory address in pObj
            IntPtr pObj = gch.AddrOfPinnedObject();
            Console.WriteLine($"Memory address str with first value: {pObj}");
            msg+="hi"; // appending
            //get memory address
            gch = GCHandle.Alloc(msg,GCHandleType.Pinned);
            pObj = gch.AddrOfPinnedObject();
            Console.WriteLine($"Memory address str with append value: {pObj}");

            //---------------------String Builder--------------------------
    
            StringBuilder sb =  new StringBuilder("");
            sb.Append("Hello World");
            Console.WriteLine(sb);
            gch = GCHandle.Alloc(sb,GCHandleType.Pinned);
            pObj=gch.AddrOfPinnedObject();
            Console.WriteLine($"Memory address str builder with first value: {pObj}");
            sb.Append("hi");
            gch = GCHandle.Alloc(sb,GCHandleType.Pinned);
            pObj=gch.AddrOfPinnedObject();
            Console.WriteLine($"Memory address str builder with append value: {pObj}");

        }
    }
}
