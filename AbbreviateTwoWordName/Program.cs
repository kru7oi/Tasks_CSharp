internal class Program
{
    // Напишите функцию для преобразования имени в инициалы.
    // Выходные данные должны состоять из двух заглавных букв с разделяющей их точкой.
    // Это должно выглядеть примерно так:
    // Сэм Харрис => S.H.
    // патрик Фини => P.F
    private static void Main(string[] args)
    {
        Console.WriteLine(AbbrevName("Vladislav Otd"));
        Console.WriteLine(AbbrevName("vlad otd"));
    }

    public static string AbbrevName(string name)
    {
        return string.Join(".", name.Split(' ').Select(word => word[0])).ToUpper();
    }

    //public static string AbbrevName(string name)
    //{
    //    string[] words = name.Split(' ');

    //    return (words[0][0] + "." + words[1][0] + ".").ToUpper();
    //}

    //public static string AbbrevName(string name)
    //{
    //    string[] nameArray = name.Split(' ');

    //    string firstName = nameArray.First();
    //    string lastName = nameArray.Last();

    //    char oneUpper = Char.ToUpper(firstName.First());
    //    char twoUpper = Char.ToUpper(lastName.First());

    //    return $"{oneUpper}.{twoUpper}.";
    //}
}