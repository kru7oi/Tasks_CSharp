internal class Program
{
    // Панграмма - это предложение, которое содержит каждую букву алфавита по крайней мере один раз.
    // Например, предложение "The quick brown fox jumps over the lazy dog" является панграммой,
    // поскольку в нем по крайней мере один раз используются буквы A-Z (регистр не имеет значения).
    // Получив строку, определите, является ли она панграммой или нет.
    // Возвращает True, если это так, и False, если нет. Игнорируйте цифры и знаки препинания.
    private static void Main(string[] args)
    {
        Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog"));
        Console.WriteLine(IsPangram("AbCdEfGhIjKlM zYxWvUtSrQpOn"));
        Console.WriteLine(IsPangram("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
        Console.WriteLine(IsPangram("This isn't a pangram!"));
        Console.WriteLine(IsPangram("ABCD45EFGH,IJK,LMNOPQR56STUVW3XYZ"));
    }
    public static bool IsPangram(string str)
    {
        return str.ToLower().Where(char.IsLetter).Distinct().Count() == 26;
    }
    
    //public static bool IsPangram(string str)
    //{
    //    return "abcdefghijklmnopqrstuvwxyz".All(x => str.ToLower().Contains(char.ToLower(x)));
    //}
}