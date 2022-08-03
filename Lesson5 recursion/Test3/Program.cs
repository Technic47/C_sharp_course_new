
// Факториал n.

int FactFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactRec(int n)
{
    if (n == 0) return 1; // Условие завершения рекурсии.
    else return n * FactRec(n - 1);
}

//Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(FactFor(10));
Console.WriteLine(FactRec(10));