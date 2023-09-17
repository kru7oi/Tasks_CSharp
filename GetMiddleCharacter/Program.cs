internal class Program
{
    // Вам будет дано слово. Ваша задача - вернуть средний символ в слове.
    // Если длина слова нечетная, верните средний символ.
    // Если длина слова четная, верните 2 средних символа.
    // Примеры:
    // test => es
    // testing => t
    private static void Main(string[] args)
    {
        Console.WriteLine(GetMiddleCharacter("test"));
        Console.WriteLine(GetMiddleCharacter("testing"));
    }

    public static string GetMiddleCharacter(string str)
    {
        return string.IsNullOrEmpty(str) ? str : str.Substring((str.Length - 1) / 2, 2 - str.Length % 2);
    }
    
    //public static string GetMiddleCharacter(string str)
    //{
    //    return str.Length % 2 == 0 ? str.Substring(str.Length / 2 - 1, 2) : str.Substring(str.Length / 2, 1);
    //}
}