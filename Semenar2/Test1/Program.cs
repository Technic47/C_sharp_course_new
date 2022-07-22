int a = 0;

a = int.Parse(Console.ReadLine());

int Sqr(int temp)
{
    int t = temp * temp;
    return t;
    
}
int b = 0;
b = Sqr(a);
Console.WriteLine($"Sqr = {b}");