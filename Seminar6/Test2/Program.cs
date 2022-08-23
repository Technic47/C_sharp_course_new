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

bool ExistTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}
bool result = ExistTriangle(a, b, c);
if (result) Console.WriteLine($"Triangle can exist!");
else Console.WriteLine($"Triangle can not exist!");