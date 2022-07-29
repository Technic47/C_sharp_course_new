int[,] matrix = new int[3, 4];

void PrintArray(int[,] mart) // create and print
{
    for (int i = 0; i < mart.GetLength(0); i++) //строки
    {
        for (int j = 0; j < mart.GetLength(1); j++) //столбцы
        {
            Console.Write($"{mart[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] mart) // Fill with random
{
    for (int i = 0; i < mart.GetLength(0); i++) //строки(0)
    {
        for (int j = 0; j < mart.GetLength(1); j++) //столбцы(1)
        {
            mart[i,j] = new Random().Next(0,10);
            Console.Write($"{mart[i, j]} ");
        }
    Console.WriteLine();
    }
}

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);