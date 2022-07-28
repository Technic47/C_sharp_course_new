// Краткие записи;

/*
while(true)
{
    int size = 0;
    Console.WriteLine("Enter:");
    int a = 50;

    if (int.TryParse(Console.ReadLine()!, out size))
    {
        Console.Write($"Your number is: {size}");
        break;
    }
}
*/
double b = 0;

double.TryParse(Console.ReadLine()!, out b); // Можно без if

Console.Write(b);