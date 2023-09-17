internal class Program
{
    // Напишите функцию, которая вычисляет индекс массы тела(bmi = вес / рост2).
    // если ИМТ <= 18,5, верните "Недостаточный вес".
    // если ИМТ <= 25,0, верните значение "Нормальный".
    // если ИМТ <= 30,0, верните "Избыточный вес".
    // если ИМТ > 30, верните "Ожирение"
    private static void Main(string[] args)
    {
        Console.WriteLine(CalculateBMI(79.0, 1.78));
    }
    public static string CalculateBMI(double weight, double height)
    {
        double bmi = weight / (height * height);

        if (bmi <= 18.5) return "Недостаточный вес";
        if (bmi > 18.5 & bmi <= 25.0) return "Нормальный";
        if (bmi > 25.0 & bmi <= 30.0) return "Избыточный вес";
        if (bmi > 30) return "Ожирение";

        return null;
    }
}