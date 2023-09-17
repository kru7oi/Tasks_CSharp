internal class Program
{
    // Вася Пупкин только начал изучать C#.
    // Сначала он решил написать простую программу, которая должна была суммировать
    // два небольших числа (числа и их сумма умещаются в байте), но это не сработало.
    // Васе было слишком грустно, чтобы выяснять, в чем дело. Помогите ему исправить ошибку.
    private static void Main(string[] args)
    {
        Console.WriteLine(Sum(5, 4));
    }

    public static byte Sum(byte a, byte b) => (byte)(a + b);

    //public static byte Sum(byte a, byte b)
    //{
    //    byte c = (byte)(a + b);
    //    return c;
    //}
}