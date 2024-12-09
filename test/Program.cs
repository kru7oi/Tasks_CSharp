internal class Program
{
    private static void Main(string[] args)
    {
        GetIntegersFromList(new List<object> { 1, 2, "a", "b" });
    }

    //public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    //{
    //    List<int> result = new List<int>();

    //    foreach (object item in listOfItems)
    //    {
    //        if (item is int)
    //        {
    //            result.Add((int)item);
    //        }
    //    }

    //    return result;
    //}

    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        return listOfItems.OfType<int>();
    }
}