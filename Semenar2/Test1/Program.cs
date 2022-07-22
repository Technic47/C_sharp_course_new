//int a = 0;
//a = int.Parse(Console.ReadLine());
//
//int Sqr(int temp)
//{
//    //int t = temp * temp;
//    return temp * temp; // Так тоже работает
//    
//}
int[] ArrayFill(int arrayLength) // New array
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;  
}

void FillArray(int[] array) // existtened array
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
int[] array1 = new int[5];
int[] array2 = new int[5];

array1 = ArrayFill(10);
FillArray(array2);

PrintArray(array1);
PrintArray(array2);

//int b = 0;
//b = Sqr(a);
//Console.WriteLine($"Sqr = {b}");