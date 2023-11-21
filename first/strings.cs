//See https://aka.ms/new-console-template for more information

//printing
string a="Sona";
Console.WriteLine(a);
Console.WriteLine("Hello "+a);
Console.WriteLine($"Hello {a}");

string b="Elizebeth";
Console.WriteLine(b);
Console.WriteLine($"{a} {b}");
Console.WriteLine(a + b);
Console.WriteLine(a+" " +b);

//Length property
Console.WriteLine($"Hi {a} and has {a.Length} Letters");

//Trim() function
string greet = "   Good Morning   ";
Console.WriteLine($"[(greet)]");
Console.WriteLine($"[{greet.Trim()}]");
Console.WriteLine($"[{greet.TrimStart()}]");
Console.WriteLine($"[{greet.TrimEnd()}]");
//or
string trimgreet=greet.Trim();
Console.WriteLine(trimgreet);

//replace function
string rep="Hello Sona";
Console.WriteLine(rep);
Console.WriteLine(rep.Replace("Hello","Greetings"));
//or
string rep1=rep.Replace("Hello","Greetings");
Console.WriteLine(rep1);

//caps and lowercase
Console.WriteLine(rep.ToUpper());
Console.WriteLine(rep.ToLower());

//search strings
string sentence="Hi I am Sona, from Kerala";
Console.WriteLine(sentence.Contains("am"));
Console.WriteLine(sentence.Contains("hi"));
//or
var result = sentence.Contains("Kerala");
Console.WriteLine(result);


//startswith and endswith
string sent="Hi I am Sona, from Kerala";
Console.WriteLine(sent.StartsWith("Hi"));
Console.WriteLine(sent.EndsWith("Kerala"));
Console.WriteLine(sent.StartsWith("HI"));
Console.WriteLine(sent.EndsWith("kerala"));


