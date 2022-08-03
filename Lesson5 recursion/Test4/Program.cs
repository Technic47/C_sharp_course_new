// Вычислить число а в степени n.

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    if (n == 0) return 1; else return PowerRec(a, n - 1) * a; // Вариант записи.
    //if (n == 0) return 1; // Условие завершения рекурсии.
    //else return PowerRec(a, n - 1) * n;
}

//Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));