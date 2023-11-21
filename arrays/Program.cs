//array

String[] fruits={"Apple","Orange","Mango","Kiwi"};
int[] number={10,12,32,44,67,89,90,100};
Console.WriteLine(fruits[2]);
Console.WriteLine(number[2]+number[6]);
number[1]=30;
Console.WriteLine(number[1]);
for(int i=0;i<=number.Length;i++){
    Console.WriteLine(number[i]);
}
foreach(int j in number){
    Console.Write(j);
}

int[,] nums = new int[2,2] {{1,2},{2,2}};
Console.WriteLine(nums[0,0]);

int[] numb={10,12,32,44,67,89,90,100};
Console.WriteLine(numb.Max());
Console.WriteLine(numb.Min());
