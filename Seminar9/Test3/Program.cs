// Списки. (динамические массивы)

List<int> array = new List<int>();
array.Add(5);
array.Add(5);
array.Add(3);
array.Add(54);
array.Add(44);
array.Add(4);
array.Add(7);

for (int j =0; j <array.Count; j++)
{
    Console.Write($"{array[j]} ");
}