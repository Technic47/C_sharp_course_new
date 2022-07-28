// Динный вариант
Console.WriteLine("Enter:");

int size = 0;
bool check = false; //false as default to prevent input errors;

//string userenter = Console.ReadLine()!;

//check = int.TryParse(userenter, out size);

//if (check) //Проверка на true/ (!check) - на false

if (int.TryParse(Console.ReadLine()!, out size))
{
    Console.Write($"Your number is: {size}");
}
else
{
    Console.Write($"Wrong enter!");
    return; // Выключит всю программу если false
}
Console.WriteLine($"\nEnd of programm");
/*
for (int i = 0; i < userenter.Length; i++) // Проверка каждого символа на то что он число согласно ASCII таблице. Аналог работы TryParse
{
    if (userenter[i] < '0' || userenter[i] > '9') // || = или
    {
        Console.Write(" Fail");
    }
}
*/