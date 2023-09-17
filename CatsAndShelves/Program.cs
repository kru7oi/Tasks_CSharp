internal class Program
{
    // Бесконечное количество полок расположено одна над другой в шахматном порядке.
    // Кошка может перепрыгивать либо с одной, либо с трех полок одновременно:
    // с полки i на полку i+1 или i +3 (кошка не может забраться на полку прямо над своей головой).

    // При вводе указывается начальный и конечный номера полок
    // (всегда целые положительные числа, конечный номер не меньше начального).

    // Найдите минимальное количество прыжков, чтобы пройти от начала до конца.

    // Пример:
    // Старт с 1, финиш на 5, ответ должен быть 2 (1 => 4 => 5 или 1 => 2 => 5).
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static int FindJumps(int start, int finish)
    {
        int difference = finish - start;
        return difference / 3 + difference % 3;
    }
    
    //public static int FindJumps(int start, int finish)
    //{
    //    int tripleJumps = (finish - start) / 3;
    //    int singleJumps = (finish - start) % 3;
    //    return tripleJumps + singleJumps;
    //}
}