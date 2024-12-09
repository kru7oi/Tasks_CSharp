Console.WriteLine(Swap("Hello World!"));

string Swap(string word)
{
    string lowerVowels = "aeiou";
    string capitalVowels = "AEIOU";
    string result = word;

    for (int i = 0; i < capitalVowels.Length; i++)
    {
        result = result.Replace(lowerVowels[i], capitalVowels[i]);
    }

    //string result = Regex.Replace(word, "[aeiou]", l => l.Value.ToUpper());

    return result;
}


// Перевести все маленькие гласные в большие