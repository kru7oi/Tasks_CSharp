internal class Program
{
    // Напишите функцию, которая преобразует входную строку в верхний регистр.
    private static void Main(string[] args)
    {
        Console.WriteLine(MakeUpperCase("asd"));
        Console.WriteLine(MakeUpperCase("asdSSS"));
    }
    public static string MakeUpperCase(string str)
    {
        return str.ToUpper();
    }
}