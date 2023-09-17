internal class Program
{
    // Завершите решение так, чтобы оно разбивало строку на пары по два символа.
    // Если строка содержит нечетное количество символов, то она должна заменить
    // отсутствующий второй символ последней пары символом подчеркивания('_').
    // Примеры:
    // "abc" =>  ["ab", "c_"]
    // "abcdef" => ["ab", "cd", "ef"]
    private static void Main(string[] args)
    {
        string[] stringArray = SplitStrings("abc");

        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
        }

        stringArray = SplitStrings("abcdef");

        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
        }
    }

    public static string[] SplitStrings(string str)
    {
        List<string> strings = new List<string>();

        if (str.Count() % 2 != 0)
        {
            str += "_";
        }

        for (int i = 0; i < str.Length; i = i + 2)
        {
            strings.Add(str.Substring(i, 2));
        }
        return strings.ToArray();
    }
}