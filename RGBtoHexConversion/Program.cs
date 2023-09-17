internal class Program
{
    // Функция rgb является неполной. Завершите её так, чтобы передача десятичных значений RGB
    // привела к возвращению шестнадцатеричного представления. Допустимые десятичные значения
    // для RGB равны 0 - 255. Любые значения, выходящие за пределы этого диапазона,
    // должны быть округлены до ближайшего допустимого значения.

    // Примечание: Ваш ответ всегда должен содержать 6 символов, сокращение с 3 здесь не сработает.
    // Примеры (ввод -> вывод):
    // 255, 255, 255 --> "FFFFFF"
    // 255, 255, 300 --> "FFFFFF"
    // 0, 0, 0       --> "000000"
    // 148, 0, 211   --> "9400D3"

    private static void Main(string[] args)
    {
        Console.WriteLine(ConvertRGBToHex(255, 255, 300));
        Console.WriteLine(ConvertRGBToHex(148, 0, 211));
        Console.WriteLine(ConvertRGBToHex(123, 54, 98));
    }

    public static string ConvertRGBToHex(int r, int g, int b)
    {
        r = Math.Max(Math.Min(255, r), 0);
        g = Math.Max(Math.Min(255, g), 0);
        b = Math.Max(Math.Min(255, b), 0);

        return string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
    }
    
    //public static string ConvertRGBToHex(int r, int g, int b)
    //{
    //    return Math.Clamp(r, 0, 255).ToString("X2") + Math.Clamp(g, 0, 255).ToString("X2") + Math.Clamp(b, 0, 255).ToString("X2");
    //}
}