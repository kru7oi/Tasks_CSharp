internal class Program
{
    // Ваша задача состоит в том, чтобы создать функцию, которая выполняет четыре основные математические операции.
    // Функция должна принимать три аргумента - operation(string/char), value1(число), value2(число).
    // Функция должна возвращать результат в виде чисел после применения выбранной операции.
    // Пример:
    // ('+', 4, 7) => 11
    // ('-', 15, 18) => -3
    // ('*', 5, 5) => 25
    // ('/', 49, 7) => 7
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static double Operation(char operation, double value1, double value2)
    {
        switch (operation)
        {
            case '+': return value1 + value2;
            case '-': return value1 - value2;
            case '*': return value1 * value2;
            case '/': return value1 / value2;
        }
        return -1;
    }
}