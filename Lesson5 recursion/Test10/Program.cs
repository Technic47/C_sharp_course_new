// Бесконечная программа.

int i = 0;
void rec()
{
    System.Console.WriteLine(i++);
    rec();
}

rec();