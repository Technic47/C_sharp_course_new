/*Есть ряд в зале кино 50 мест.
Рандомно заполняется 0 и 1. 0 - пусто, 1 занято. 
Принимает число.
Найти отрезок в это число в ряду
с свободными местами.
Вывести индексы первого и последнего места.
*/

int[] array = new int[50];
Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine()!);


int index = 0;
int count = 0;

Console.WriteLine("Your array is:");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write($"{array[i]} ");
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == 0)
    {
        count ++;
        if (count == N) 
        {
            index = i;
            Console.WriteLine($"\n{(index - N)+2}, {index +1}");
            return;
        }
    }
    else count = 0;
}
// 