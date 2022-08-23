/* Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.
*/

Console.WriteLine("Enter array length :");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
void CopyArray (int[] array)
{
    int[] array2 = new int[n];
    for (int  i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
        Console.Write($"{array2[i]} ");
    }
}

CopyArray(array);