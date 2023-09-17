internal class Program
{
    // Завершите решение так, чтобы оно возвращало значение true, если первый переданный аргумент (строка)
    // заканчивается 2-м аргументом (также строкой).
    // Пример:
    // solution('abc', 'bc') returns true
    // solution('abc', 'd') returns false
    private static void Main(string[] args)
    {
        Console.WriteLine(IsStringEnd("string", "g"));
        Console.WriteLine(IsStringEnd("string", "ing"));
        Console.WriteLine(IsStringEnd("string", "asd"));
    }
    public static bool IsStringEnd(string str, string ending)
    {
        return str.EndsWith(ending);
    }
}