/***Задача 42:** Напишите программу,
 которая будет преобразовывать десятичное число
 в двоичное.
*/

Console.WriteLine("Number for conversion:");
long a = long.Parse(Console.ReadLine()!);

long b = 0;
long number = 0;
long c = 1;

for (int i = 1; a != 0; i++)
{
    b = a % 2;
    a = a / 2;
    c = c * 10;
    number = number + b * c;
}

Console.WriteLine($"Number in BIN:\n{number / 10}");

void DecToBin(long a) // рекурсия
{
    if (a == 0) return; // условие выхода
    DecToBin(a / 2);
    Console.Write(a % 2);
}
Console.WriteLine($"Number in BIN (recursion): ");
DecToBin(13);