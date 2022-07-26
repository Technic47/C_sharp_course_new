/*Напишите программу, 
которая принимает на вход число N
 и выдаёт произведение чисел от 1 до N.

4  -> 24
5  -> 120
*/

int A = int.Parse(Console.ReadLine()!);

long Sum(int A)
{
    long sum = 1;
    for(int i = 1; i <= A; i++)
    {
        sum = sum * i;
    }
    return sum;
}

Console.WriteLine(Sum(A));


//заполнить массив из восьми элементов 0 и 1 рандомно
/*Console.WriteLine("Enter array size:");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[] array = new int[A];

int i = 0;
while ( i < array.Length)
{
    array[i] = new Random().Next(0,2);
    Console.Write($"{array[i]} ");
    i++;
}
*/