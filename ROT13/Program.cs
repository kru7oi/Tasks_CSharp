Console.WriteLine(Rot13("GUVF."));


string Rot13(string input)
{
    char[] chars = input.ToCharArray();

    for (int i = 0; i < chars.Length; i++)
    {
        if (char.IsLetter(chars[i]))
        {
            char c = char.IsUpper(chars[i]) ? 'A' : 'a';
            chars[i] = (char)((((chars[i] + 13) - c) % 26) + c);
        }
    }
    return new string(chars);
}

// string input = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
// string output = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
// return string.Join("", input.Select(c => char.IsLetter(c) ? s1[s2.IndexOf(c)] : c));
