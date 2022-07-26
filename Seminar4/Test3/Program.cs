//Сумма чисел от 1 до А
int A = int.Parse(Console.ReadLine()!);

int Sum(int A)
{
    int sum = 0;
    for(int i = 1; i <= A; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine(Sum(A));