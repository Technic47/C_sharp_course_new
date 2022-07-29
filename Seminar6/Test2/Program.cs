/*
**Задача 40:** Напишите программу, 
которая принимает на вход три числа и проверяет, 
может ли существовать треугольник 
с сторонами такой длины.
❗ **Теорема о неравенстве треугольника:** 
каждая сторона треугольника меньше суммы 
двух других сторон.
*/

Console.WriteLine("Number A:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Number B:");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Number C:");
int c = int.Parse(Console.ReadLine()!);

int Check(int x, int y)
{
    int c = x + y;
    return c;
}
if (a < Check(b, c) && b < Check(a, c) && c < Check(a, b))
    {
        Console.WriteLine($"Triangle can exist!");
    }
else Console.WriteLine($"Triangle can not exist!");