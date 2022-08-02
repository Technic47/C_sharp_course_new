/***Задача 55:** Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
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
    for (int i = 0; i < m; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

PrintArray(array);
ChangeArray(array);
Console.WriteLine();
PrintArray(array);