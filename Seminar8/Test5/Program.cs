/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных
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

void PrintArray2D(int[,] array)
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

int[] CheckMatrix(int[,] array, int max)
{
    int[] resarray = new int[(max+1)];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resarray[array[i, j]] += 1;
        }
        
    }
    return resarray;
}

void PrintArray(int[] array)
{
    Console.WriteLine();

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Number {i} = {array[i], 2} times");
        }
    
}

int[,] array = CreateMatrixRnd(m, n, 0, 10);
PrintArray2D(array);
int[] resarray = CheckMatrix(array, 10);
PrintArray(resarray);