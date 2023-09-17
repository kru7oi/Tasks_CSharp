internal class Program
{
    // Завершите решение так, чтобы оно изменило переданную в него строку на противоположную.
    // Примеры:
    // 'world'  =>  'dlrow'
    // 'word'   =>  'drow'
    private static void Main(string[] args)
    {
        Console.WriteLine(ReverseString("world"));
        Console.WriteLine(ReverseString("word"));
    }

    public static string ReverseString(string str)
    {
        return string.Concat(str.Reverse());
    }

    //public static string ReverseString(string str)
    //{
    //    return new String(str.Reverse().ToArray());
    //}
}