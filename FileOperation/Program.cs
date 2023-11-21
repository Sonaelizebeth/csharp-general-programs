using System;
using System.IO;
namespace FileOp{
    class FileOperation{
        static void Main(string[] args){
            string contents = "First file content";
            File.WriteAllText("myfile.txt",contents);
            Console.WriteLine(File.ReadAllText("myfile.txt"));
        }
    }
}
