internal class Program
{
    // Напишите функцию, которая вычисляет среднее значение чисел в заданном массиве.
    // Примечание: Пустые массивы должны возвращать 0
    private static void Main(string[] args)
    {
        Console.WriteLine(FindAverage(new double[] { 7.4, 8.0, 19.0, -4.5}));
        Console.WriteLine(FindAverage(new double[] { 7.0, 7.0, 7.0, 7.0}));
        Console.WriteLine(FindAverage(new double[] { }));
    }
    public static double FindAverage(double[] array)
    {
        if (array.Length == 0) return 0;
        return array.Average();
    }
}