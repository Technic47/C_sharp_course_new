/* **Задача 51:** Задайте двумерный массив размера m на n, 
найти сумму главной и обратной диагонали
*/

int m = 0;
int n = 0;
//int sum = 0; // 0,0  1,1  2,2 .....
//int sum2 = 0; // 0,5  1,4  2,3  3,2  4,1  5,0

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

int CovertMatrixMain (int[,] array) // главная
{
    
    int sum = 0;
    int size = Math.Min(array.GetLength(0), array.GetLength(1));
    for (int i = 0; i < size; i++)
    {
         sum += array[i, i];
    }
    return sum;
}

int CovertMatrixReverse (int[,] array) // обратная
{
    int sum2 = 0;
    int size = Math.Min(array.GetLength(0), array.GetLength(1));
    for (int i = 0; i < size; i++)
    {
        sum2 += array[i, (array.GetLength(1)-1) - i];
    }
    return sum2;
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
int sum = CovertMatrixMain (array);
int sum2 = CovertMatrixReverse (array);
PrintArray(array);
Console.WriteLine($"Sum main: {sum}; Sum reverse: {sum2}");