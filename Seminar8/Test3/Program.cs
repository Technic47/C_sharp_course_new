/* **Задача 53:** Задайте двумерный массив. 
Напишите программу, которая поменяет местами 
первую и последнюю строку массива.
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
    Random rnd = new Random(); 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{array[i, j], 2} ");
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] array)
{    
    int n = array.GetLength(1);
    for (int j = 0; j < n; j++)
    {
        int temp = array[0, j];
        array[0, j] = array[n - 1, j];
        array[n - 1, j] = temp;
    }
}

int[,] array = CreateMatrixRnd(m, n, 0, 9);
PrintArray(array);
ChangeArray(array);
PrintArray(array);