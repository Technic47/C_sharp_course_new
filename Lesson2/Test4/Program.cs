﻿void FillArray(int[] collection)  //Function of filling array with random numbers
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[]array = new int[10]; //Create new array with 10 int numbers [0,0,0,0,0,0,0,0,0,0]

FillArray(array); //Filled
PrintArray(array); //Printed