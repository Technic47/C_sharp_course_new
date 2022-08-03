// Сколько сочетаний букв(слов) из представленного количества.
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length) // выход из рекурсии.
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("acbf", new char[4]);