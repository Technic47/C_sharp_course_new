/* **Задача 49:** Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
найти элементы с чётными индексами и возвести в квадрат
*/

int m = 0;
int n = 0;

Console.WriteLine("Enter M:");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Enter N:");
int.TryParse(Console.ReadLine(), out n);

int[,] CreateMatrixRnd (int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random rnd = new Random(); // правильная запись rnd
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1); // правильная запись rnd
        }
    }
    return array;
}

int[,] CovertMatrix (int[,] array) // первый вариант
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            //if (i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j]; // долгое решение
            array[i, j] *= array[i, j];
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j], 3} ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateMatrixRnd(m, n, 0, 9);
PrintArray(array);
Console.WriteLine();
CovertMatrix(array);
PrintArray(array);