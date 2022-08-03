
// Сумма чисел от 1 до n.
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0; // Условие завершения рекурсии.
    else return n + SumRec(n - 1);
}

//Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));