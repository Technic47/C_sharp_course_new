/*
string[,] table = new string[2, 5];
//table[0, 0] table[0, 1] table[0, 2] table[0, 3]
//table[1, 0] table[1, 1] table[1, 2] table[1, 3]

table[1, 2] = "Text"; // обращение к массиву

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"--{table[rows, columns]}-");
    }
}
*/
int[,] matrix = new int[3, 4]; // вывод в виде матрицы

for (int i = 0; i < matrix.GetLength(0); i++) //строки
{
    for (int j = 0; j < matrix.GetLength(1); j++) //столбцы
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}