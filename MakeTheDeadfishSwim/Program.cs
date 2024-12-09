foreach (var item in Parse("iiisdoso"))
{
    Console.WriteLine(item);
}

int[] Parse(string data)
{
    int startNumber = 0;

    List<int> result = new List<int>();

    char[] chars = data.ToCharArray();

    for (int i = 0; i < chars.Length; i++)
    {
        switch (chars[i])
        {
            case 'i':
                startNumber++;
                break;
            case 's':
                startNumber *= startNumber;
                break;
            case 'd':
                startNumber--;
                break;
            case 'o':
                result.Add(startNumber);
                break;
            default:
                break;
        }
    }

    return result.ToArray();
}
