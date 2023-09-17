internal class Program
{
    // Учитывая набор чисел, верните аддитивное значение, обратное каждому из них.
    // Каждое положительное становится отрицательным, а отрицательное становится положительным.
    // Пример:
    // Invert([1, 2, 3, 4, 5]) == [-1, -2, -3, -4, -5]
    // Invert([1, -2, 3, 4, 5]) == [-1, 2, -3, -4, -5]
    private static void Main(string[] args)
    {
        int[] numbersArray = InvertValues(new int[] { 3, -5, 6, 17, -2 });

        foreach (int number in numbersArray)
        {
            Console.WriteLine(number);
        }
    }
    public static int[] InvertValues(int[] input)
    {
        return input.Select(n => -n).ToArray();
    }

    //public static int[] InvertValues(int[] input)
    //{
    //    for (int i = 0; i < input.Count(); i++)
    //    {
    //        input[i] *= -1;
    //    }

    //    return input;
    //}
}