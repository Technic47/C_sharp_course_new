/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

456 -> 3

78 -> 2

89126 -> 5
*/

int A = int.Parse(Console.ReadLine()!);

int Size(int A)
{
    if (A == 0) return 1;
    int dev = 0;
    for (int i = 0; A != 0; i++)
    {
        A = A/10;
        //dev += 1;
        dev = dev + 1;
    }
    return dev;
}
Console.WriteLine(Size(A));