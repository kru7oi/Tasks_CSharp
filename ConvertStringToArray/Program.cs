internal class Program
{
    // Напишите функцию для разделения строки и преобразования ее в массив слов.
    // Пример:
    // "String Array" => ["String", "Array"]
    private static void Main(string[] args)
    {
        string[] stringsArray = StringToArray("String Testing");

        foreach (string s in stringsArray)
        {
            Console.WriteLine(s);
        }
    }

    public static string[] StringToArray(string str)
    {
        return str.Split(' ');
    }
}