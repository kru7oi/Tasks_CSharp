// Учитывая массив целых чисел, найдите то, которое появляется нечетное число раз.

// Всегда будет только одно целое число, которое появляется нечетное число раз.

// Examples
// [7] should return 7, because it occurs 1 time (which is odd).
// [0] should return 0, because it occurs 1 time (which is odd).
// [1,1,2] should return 2, because it occurs 1 time (which is odd).
// [0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
// [1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(FindOdd(new int[] { 1, 2, 2, 3, 3, 4, 3, 3, 3, 2, 2, 1 }));
    }

    public static int FindOdd(int[] integerArray)
    {
        return integerArray.First(value => integerArray.Count(number => number == value) % 2 != 0);
    }

    //public static int FindOdd(int[] integerArray)
    //{
    //    Dictionary<int, int> integerDictionary = new Dictionary<int, int>();

    //    foreach (int integer in integerArray)
    //    {
    //        integerDictionary.TryGetValue(integer, out int count);
    //        integerDictionary[integer] = ++count;
    //    }

    //    foreach(KeyValuePair<int, int> pair in integerDictionary)
    //    {
    //        if (pair.Value % 2 !=0)
    //        {
    //            return pair.Key;
    //        }
    //    }

    //    return -1;
    //}
}