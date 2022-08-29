//string str = string.Format("{0:t} {0:d} {1:f1}", DateTime.Now, 20.54); // форматирование строки с данными Format
//Console.Write(str);

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(string.Format("{0,2:d} ", array[i, j])); // выделяет 2 ячейки под символы
        }
        Console.WriteLine();
    }
}

int[,] array = CreateMatrixRnd(m, n, 0, 99);
PrintArray(array);