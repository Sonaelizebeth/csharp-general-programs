// See https://aka.ms/new-console-template for more information
//integer precision and limits

int a=7;
int b=4;
int c=3;
int d=(a+b)/c;
int e=(a+b)%c;
Console.WriteLine($"Quotient: {d}");
Console.WriteLine($"Remainder {e}");

//to find the min and max of int
int min=int.MinValue;
int max=int.MaxValue;
Console.WriteLine($"The min and max of int are {min} and {max} respectively");

//underflow or overflow
int what = max+3;
Console.WriteLine($"An eg of overflow {what}");

//work with double type
double f =5;
double g=4;
double h=2;
double i = (f+g)/h;
Console.WriteLine(i);

double min1=double.MinValue;
double max1=double.MaxValue;
Console.WriteLine($"The min and max are {min1} and {max1}");

double third=1.0/3.0;
Console.WriteLine(third);

//area of circle
double radius=2.50;
double area=Math.PI*radius*radius;
Console.WriteLine(area);

//work with decimal types
decimal min2 = decimal.MinValue;
decimal max2=decimal.MaxValue;
Console.WriteLine($"The min and max are {min2} and {max2}");

double j=1.0;
double k=3.0;
Console.WriteLine(j/k);

decimal l=1.0M;
decimal m=3.0M;
Console.WriteLine(l/m);

