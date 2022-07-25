int num = new Random().Next(10, 100);

int a1 = num / 10; // целая часть - первое число
int a2 = num % 10; // дробная - второе число

Console.Write(num);
if (a1 > a2) // ищем большее из 2х чисело и выводим
{
    Console.Write($" -> {a1}");
}
else
{
    Console.Write($" -> {a2}");

}