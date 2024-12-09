
using System.Text;

Console.WriteLine(Accum("abcd"));

String Accum(string s)
{
    StringBuilder result = new StringBuilder();

    for (int i = 0; i < s.Length; i++)
    {
        char currentChar = s[i];
        string repeatedChars = new string(currentChar, i);
        result.Append(char.ToUpper(currentChar));
        result.Append(repeatedChars.ToLower());
        if (i < s.Length - 1)
        {
            result.Append('-');
        }
    }

    return result.ToString();
}