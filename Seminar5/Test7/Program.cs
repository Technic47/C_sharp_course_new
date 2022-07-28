//Дан массив чисел. Посчитайте, сколько в нем пар элементов, равных друг другу.
//Считается, что любые два элемента, равные друг другу образуют одну пару, которую необходимо посчитать.

Console.WriteLine("Enter array length: ");
int N = int.Parse(Console.ReadLine()!);
int[] array = new int[N];

int number1 = 0;
int pair = 0;

Console.WriteLine("Your array is:");

for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(0, 4);
    Console.Write($"{array[i]} ");
}

for (int i = 0; i < N; i++)
{
    number1 = array[i];
    for (int j = i+1; j < N; j++)
    {
        if (array[j] == number1)
        {
            pair++;
        }
    }
}

Console.WriteLine($"\nNumber of pairs: {pair}");

