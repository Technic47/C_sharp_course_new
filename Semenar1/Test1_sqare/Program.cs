int number = 0;

Console.WriteLine("Enter number: ");
string userenter = Console.ReadLine();

bool enter = int.TryParse(userenter, out number); //Перевод username в int и запись в number
//если получится, то bool = true
if (enter)
{
    Console.Write($"Sqare {number} = {number * number}");
}
//если не получится перевести, то bool = false
if (!enter)
{
    Console.Write("Wrong input");
}
