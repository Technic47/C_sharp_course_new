/*Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
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

int[] CheckMin(int[,] array)
{
        int min = 999;
        int[] mincoord = new int[2];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i,j]<min) 
                {
                    min = array[i,j];
                    mincoord[0] = i;
                    mincoord[1] = j;

                }
                
            }
            
        }
        return mincoord;
}

void DeleteCross(int[,]array, int[] mincoord)
{
    int[,] newArray = new int[m-1,n-1];
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                if(i = mincoord[0])
                newArray[i,j] == array[i,j];
            }
            
        }
}

int[,] array = CreateMatrixRnd(m, n, 0, 20);
PrintArray2D(array);
int[] mincoord = CheckMin(array);
for (int i=0;i<mincoord.Length; i++)
{
    Console.Write($"{mincoord[i]} ");
}
