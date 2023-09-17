internal class Program
{
    // Учитывая непустой массив целых чисел, верните результат умножения значений по порядку.
    // Пример:
    // [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
    private static void Main(string[] args)
    {
        Console.WriteLine(ReduceArray(new int[] { 3, 4, 10 }));
    }

    public static int ReduceArray(int[] numbersArray)
    {
        int result = 1;

        foreach (int number in numbersArray)
        {
            result *= number;
        }

        return result;
    }

    //public static int ReduceArray(int[] numbersArray)
    //{
    //    return numbersArray.Aggregate((a, b) => a * b);
    //}
}