internal class Program
{
    // Создайте функцию, которая принимает целое число в качестве аргумента
    // и возвращает "Четное" для четных чисел или "Нечетное" для нечетных чисел.
    private static void Main(string[] args)
    {
        Console.WriteLine(EvenOrOdd(25));
        Console.WriteLine(EvenOrOdd(14));
    }
    public static string EvenOrOdd(int number)
    {
        return number % 2 == 0 ? "Чётное" : "Нечётное";
    }

    //public static string EvenOrOdd(int number)
    //{
    //    if (number % 2 == 0)
    //    {
    //        return ("Even");
    //    }
    //    else
    //    {
    //        return ("Odd");
    //    }
    //}
}