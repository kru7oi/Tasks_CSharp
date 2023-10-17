internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(RepeatString(3, "**"));
    }
    public static string RepeatString(int count, string value)
    {
        string result = "";

        for (int i = 0; i < count; i++)
        {
            result += value;
        }

        return result;
    }

    //public static string RepeatString(int count, string value)
    //{
    //    return string.Concat(Enumerable.Repeat(value, count));
    //}

    //public static string RepeatString(int count, string value)
    //{
    //    return string.Join("", Enumerable.Repeat(value, count));
    //}
}