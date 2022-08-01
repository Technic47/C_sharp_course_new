/* **Задача 48:** Задайте двумерный массив размера m на n, 
найти сумму главной и обратной диагонали
*/

int m = 0;
int n = 0;
int sum = 0; // 0,0  1,1  2,2 .....
int sum2 = 0; // 0,5  1,4  2,3  3,2  4,1  5,0

int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        if (i == j) sum = sum + array[i, j]; // Главная
        //if (i == (m-1) - j && j == (n-1) - i) sum2 = sum2 + array[i, j]; // Обратная
        if (i + j == n - 1) sum2 = sum2 + array[i, j]; // Обратная 2й вариант
        //Console.WriteLine($"{sum2} ");
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

PrintArray(array);

Console.WriteLine($"Sum1: {sum}; Sum2: {sum2}");