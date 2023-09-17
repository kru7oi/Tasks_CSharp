internal class Program
{
    // Ваша задача состоит в том, чтобы написать функцию, которая принимает три целых числа a, b и c
    // в качестве аргументов и возвращает True, если ровно два из трех целых чисел
    // являются положительными числами(больше нуля), и False - в противном случае.

    // Примеры:
    // TwoArePositive(2, 4, -3) == true
    // TwoArePositive(-4, 6, 8) == true
    // TwoArePositive(4, -6, 9) == true
    // TwoArePositive(-4, 6, 0) == false
    // TwoArePositive(4, 6, 10) == false
    // TwoArePositive(-14, -3, -4) == false
    private static void Main(string[] args)
    {
        Console.WriteLine(TwoArePositive(-4, 6, 0));
        Console.WriteLine(TwoArePositive(6, 5, -3));
    }

    public static bool TwoArePositive(int a, int b, int c)
    {
        int count = 0;

        if (a > 0) count++;
        if (b > 0) count++;
        if (c > 0) count++;

        return (count == 2) ? true : false;
    }
}