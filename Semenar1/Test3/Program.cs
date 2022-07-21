int number = 0;
Console.Write("Input day number: ");
string userenter = Console.ReadLine();

number = int.Parse(userenter);

if(number == 1)
{
    Console.Write("It is Monday");
}
else if(number == 2)
{
    Console.Write("It is Tuesday");
}
else if(number == 3)
{
    Console.Write("It is Wednesday");
}
else if(number == 4)
{
    Console.Write("It is Thursday");
}
else if(number == 5)
{
    Console.Write("It is Friday");
}
else if(number == 6)
{
    Console.Write("It is Saturday");
}
else if(number == 7)
{
    Console.Write("It is Sunday");
}
else
{
    Console.Write("Wrong number");
}