// dictionaries
Dictionary<string,long> phonebook= new Dictionary<string, long>();
phonebook.Add("Mark",673233354);
phonebook["Paul"]=24538755;
Console.WriteLine(phonebook.Count);
if(phonebook.ContainsKey("Mark")){
    Console.WriteLine($"Mark number is {phonebook["Mark"]}");
}
phonebook.Remove("Paul");
Console.WriteLine(phonebook.Count);