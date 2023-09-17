internal class Program
{
    // В этом небольшом задании вам дается строка чисел, разделенных пробелом,
    // и вы должны вернуть наибольшее и наименьшее число.
    // Пример:
    // "1 2 3 4 5" => return "5 1"
    private static void Main(string[] args)
    {
        Console.WriteLine(HighAndLow("3 5 9 10 -5 6 111"));
    }
    public static string HighAndLow(string numbers)
    {
        IEnumerable<int> parsed = numbers.Split().Select(int.Parse);
        return parsed.Max() + " " + parsed.Min();
    }

    //public static string HighAndLow(string numbers)
    //{
    //    IEnumerable<int> numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
    //    return string.Format("{0} {1}", numbersList.Max(), numbersList.Min());
    //}
}