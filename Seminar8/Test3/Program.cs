/* **Задача 53:** Задайте двумерный массив. 
Напишите программу, которая поменяет местами 
первую и последнюю строку массива.
*/
int m = 0;
int n = 0;
Console.WriteLine("Enter M");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Enter N");
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine();

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 100);
    }
}

void PrintArray(int[,] array)
{
    int[] array2 = new int[n];
    for (int i = 0; i < m; i++)

    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(string.Format("{0,2:d} ", array[i, j]));
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] array)
{
    int temp = 0;
    for (int j = 0; j < n; j++)

    {
        temp = array[0, j];
        array[0, j] = array[n - 1, j];
        array[n - 1, j] = temp;
    }
}

PrintArray(array);
ChangeArray(array);
Console.WriteLine();
PrintArray(array);