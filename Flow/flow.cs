//simple function
void function1(){
    Console.WriteLine("Good Morning");
}
function1();

//function with parameters

void sum(int x, int y){
    int sum = x+y;
    Console.WriteLine($"Sum is {sum}");
}
sum(100,200);

//function with return type
int findsq(int x){
    int result=x*x;
    return result;
}
findsq(3);