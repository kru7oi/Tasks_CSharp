//Вам даны два внутренних угла (в градусах) треугольника.
//Напишите функцию, возвращающую 3-е число.
//Примечание: будут проверяться только положительные целые числа.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(ThirdAngle(35, 85));
    }

    public static int ThirdAngle(int firstAngle, int secondAngle)
    {
        return 180 - (firstAngle + secondAngle);
    }
}