/* **Задача 48:** Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
найти элементы с чётными индексами и возвести в квадрат
*/

int m = 0;
int n = 0;

int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = i + j;
        if (i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j]; // первый вариант
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();

/*void PrintArraySqr(int[,] array)  // другой вариант
{
    for (int i = 0; i < m; i += 2)
    {

        for (int j = 0; j < n; j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];

        }
    }
}
*/
//PrintArraySqr(array);
PrintArray(array);