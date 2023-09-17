internal class Program
{
    // Получив список целых чисел, определите, является ли сумма его элементов нечетной или четной.
    // Укажите свой ответ в виде строки, соответствующей "нечетному" или "четному".
    // Если входной массив пуст, рассматривайте его как: [0] (массив с нулем).

    // Примеры:
    // Input: [0]
    // Output: "even"
    
    // Input: [0, 1, 4]
    // Output: "odd"
    
    // Input: [0, -1, -5]
    // Output: "even"
    private static void Main(string[] args)
    {
        Console.WriteLine(OddOrEven(new int[] {0, 1, 4}));
        Console.WriteLine(OddOrEven(new int[] {0}));
        Console.WriteLine(OddOrEven(new int[] {0, -1, -5}));
    }
    public static string OddOrEven(int[] array)
    {
        return array.Sum() % 2 == 0 ? "even" : "odd";
    }
    //public static string OddOrEven(int[] array)
    //{
    //    int result = 0;
    //    foreach (int i in array)
    //    {
    //        result += i;
    //    }
    //    return result % 2 == 0 ? "even" : "odd";
    //}
}