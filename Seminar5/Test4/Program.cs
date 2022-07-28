int[] array = new int[12];

for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]} ");
    array[i] *= -1;
}
Console.WriteLine();

foreach (int element in array)
    Console.Write(element + " ");

