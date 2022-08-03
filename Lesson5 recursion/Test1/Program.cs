string NumbersFor(int a, int b)
{
    string result = String.Empty;
    //for (int i = a; i <= b; i++) //1 2 3 4 5...
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    //if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}

//Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersFor(10, 1));
Console.WriteLine(NumbersRec(1, 10));