int[] array = new int[12];

int sum1 = 0;
int sum2 = 0;

for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]} ");
    if (array[i] < 0)
    {
        sum1 += array[i];
    }
    else
        sum2 += array[i];
}
/*
// foreach - only for arrays
foreach (int element in array) //для каждого элемента из массива ... element задавать нельзя
{
    //element - не элемент массива, а его значение уже заданное
    sum += element;
    Console.Write($"{element} ");
}
*/
Console.Write($"\nSum of positive elements is: {sum1} ");
Console.Write($"\nSum of negative elements is: {sum2} ");