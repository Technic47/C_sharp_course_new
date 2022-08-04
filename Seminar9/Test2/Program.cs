// Вывести все натур числа от M до N

int M = 0;
int N = 0;

int.TryParse(Console.ReadLine(), out M);
int.TryParse(Console.ReadLine(), out N);

string Function(int M, int N)
{
    if (M == N) return M.ToString();
    else
    {
        return (M + " " + Function(M + 1, N));
    }
}
if (M < N) Console.Write(Function(M, N));
else Console.WriteLine("Wrong input! ");