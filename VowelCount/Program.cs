using System.Text.RegularExpressions;

internal class Program
{
    // Напишите функцию, которая возвращает количество гласных в данной строке.
    // Мы будем рассматривать A, E, I, O, U в качестве гласных для этого решения (но не Y).
    // Входная строка будет состоять только из строчных букв и/или пробелов.
    private static void Main(string[] args)
    {
        Console.WriteLine(GetVowelCount("stringFORtestING"));
    }

    public static int GetVowelCount(string str)
    {
        return str.Count(c => "aeiouAEIOU".Contains(c));
    }

    //public static int GetVowelCount(string str)
    //{
    //    return Regex.Matches(str, @"[aeiouAEIOU]").Count;
    //}
}