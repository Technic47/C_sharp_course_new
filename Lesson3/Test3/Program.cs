string text = "I checked this message for stupidity"
+" and found out that"
+" I am not able to read.";

// string 5 = "text" => "0123" как массив
//s[3] => t

string Replace(string text, char oldW, char newW)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if (text[i] == oldW) result = result + $"{newW}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'c', 'C');
Console.WriteLine(newText);