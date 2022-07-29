/***Задача 42:** Напишите программу,
 которая будет преобразовывать десятичное число
 в двоичное.
*/

Console.WriteLine("Number for conversion:");
long a = long.Parse(Console.ReadLine()!);

long b = 0;
long number = 0;
long c = 1;
for (int i = 1; a !=0; i++)
{
    b = a % 2;
    a = a/2;
    c = c*10;
    number = number + b*c;     
}

Console.WriteLine($"Number in BIN: {number/10}");