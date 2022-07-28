/*Задача 33:** Задайте массив. 
Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да
*/

int[] array = new int[12];
Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine()!);
bool B = false;

Console.WriteLine("Your array is:");

for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
    if (array[i] == N)
    {
        B = true;
    }
}

Console.WriteLine($"\n{B}");