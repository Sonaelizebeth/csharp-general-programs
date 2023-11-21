// See https://aka.ms/new-console-template for more information

//if
int a=5;
int b=6;
if(a+b>10)
    Console.WriteLine($"The answer {a+b} greater than 10");

//if else
int c=5;
int d=3;
if(c+d>10)
    Console.WriteLine($"The answer {c+d} greater than 10");
else
    Console.WriteLine($"The answer {c+d} lesser than 10");

int e = 5;
int f = 3;
int g = 4;
if ((e+f+g > 10) && (e==f))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

if((e+f+g>10)||(e==f)){
    Console.WriteLine("The ans is greater than 10 \n or equals");
}
else{
    Console.WriteLine("The ans is less than 10 \n or not equals");
}

//while
int counter=0;
while(counter<10){
    Console.WriteLine(counter);
    counter++;
}

//do while
int count=0;
do{
    Console.WriteLine(count);
    count++;
}while(count<10);

//for
for(int k=0;k<=10;k++){
    Console.WriteLine(k);
}

//nested loops
for(int l=1;l<11;l++){
    for(char m='a';m<'k';m++){
        Console.WriteLine((l,m));
    }
}
//or 
for (int row = 1; row < 11; row++)
{
  for (char column = 'a'; column < 'k'; column++)
  {
    Console.WriteLine($"The cell is ({row}, {column})");
  }
}


int sum = 0;
for (int number = 1; number < 21; number++)
{
  if (number % 3 == 0)
  {
    sum = sum + number;
  }
}
Console.WriteLine($"The sum is {sum}");