//Перебрать значения (цыклы)
int maxNum = 20;

//1st
int a = 0;
while(a <= maxNum)
{
    Console.Write($"{a} ");
    a++;
}

//2nd
Console.WriteLine();
for(int i = 0; i <= 20; i++)
{
    Console.Write($"{i} ");
}

//3rd
a = 0;
Console.WriteLine();
do
{
    Console.Write($"{a} ");
    a++;
} while (a <= maxNum);