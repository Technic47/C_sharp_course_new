int number = 0;

Console.WriteLine("Enter number: ");
string userenter = Console.ReadLine();
number = int.Parse(userenter);

Console.Write($"Sqare {number} = {number * number}");