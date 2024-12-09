internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static int[] BubbleSortOnce(int[] input)
    {
        int[] arr = input;
        int temporary = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[i] > arr[j + 1])
                {
                    temporary = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temporary;
                }
            }
        }

        return arr;
    }
}