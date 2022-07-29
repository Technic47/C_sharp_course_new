int size = 10;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(10); // 0...9
    Console.Write($"{array[i]} ");
}

int[] Reverse(int[] t_array) // переворот массива через подменный (быстрее). Изначальный сохраняется.
{
    int[] tempArray = new int[t_array.Length];

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = t_array[tempArray.Length - i - 1];
    }
    return tempArray;
}

void Reverse2 (int[] t_Array) // переворот изначального, который не сохраняется.
{
    for (int i = 0; i < (t_Array.Length/2); i++)
    {
        int j = t_Array.Length - i - 1;
        int temp = t_Array[i];
        t_Array[i] = t_Array[j];
        t_Array[j] = temp;
    }
    return;
}

int[]newArray = Reverse(array);
Console.WriteLine($"\nReverse: ");
for  (int i = 0; i < size; i++)
{
    Console.Write($"{newArray[i]} ");
}
Reverse2(array);
Console.WriteLine($"\nReverse2: ");
for  (int i = 0; i < size; i++)
{
    Console.Write($"{array[i]} ");
}
