nt[]array = {1,2,3,4,5,4,7,4,9};

int n = array.Length; //Length of array

int find = 4;

int index = 0;

while (index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}i