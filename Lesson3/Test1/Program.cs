string Method4 ( int count, string text)
{
    
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
Console.WriteLine(Method4(5, "Text"));