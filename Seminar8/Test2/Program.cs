﻿/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
*/

int m = 0;
int n = 0;
Console.WriteLine("Enter M");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Enter N");
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine();

double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        // проще обычный Next / 10 или 100 и переводить в float/double
        array[i, j] = new Random().NextDouble() * 2000 - 1000;
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(string.Format("{0:f} ", array[i, j])); // не изменяя число ограничиваем вывод

        }
        Console.WriteLine();
    }
}

PrintArray(array);

Console.Write($"\n{Math.Round(array[2,0],4)}"); // округяет число до указанных знаков после запятой. Округляет.