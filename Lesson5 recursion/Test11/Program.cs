// Перегрузка.

int[,] dickpic = new int[1000, 1000];
for (int i = 0; i < 1000; i++)
{
    dickpic[0, i] = 1;
    dickpic[i, 0] = 1;
    dickpic[i, 999] = 1;
    dickpic[999, i] = 1;
}
void PrintArray(int[,] img) // create and print
{
    for (int i = 0; i < img.GetLength(0); i++) //строки
    {
        for (int j = 0; j < img.GetLength(1); j++) //столбцы
        {
            //Console.Write($"{img[i, j]} ");
            if (img[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillArray(int row, int col) // рекурсия
{
    if (dickpic[row, col] == 0)
    {
        dickpic[row, col] = 1;
        FillArray(row - 1, col);
        FillArray(row, col - 1);
        FillArray(row + 1, col);
        FillArray(row, col + 1);
    }
}


//PrintArray(dickpic);
FillArray(10, 10);
//PrintArray(dickpic);