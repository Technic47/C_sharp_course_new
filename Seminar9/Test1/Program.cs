// Вывести все натур числа от 0 до N

int N = 0;

int.TryParse(Console.ReadLine(), out N);

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString(); // Завершение рекурсии.
    else
        return (start + " " + PrintNumbers(start + 1, end));
}

Console.Write(PrintNumbers(1, N));