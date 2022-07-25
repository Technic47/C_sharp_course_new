//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int a = 0;
a = int.Parse(Console.ReadLine());

if (((a % 7) == 0) && ((a % 23) == 0))
{
    Console.WriteLine("True");
}
else 
{
    Console.WriteLine("False");
}
