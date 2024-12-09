using System.Numerics;

Console.WriteLine(SumStrings("123", "456"));

string SumStrings(string a, string b)
{
    // TryParse делает проверку на преобразование. Если можно преобразовать => возвращает true. Иначе => false.
    // При успешном преобразовании возвращает переменную с числом. Иначе в число присваивает 0.
    BigInteger.TryParse(a, out BigInteger number1);
    BigInteger.TryParse(b, out BigInteger number2);

    return (number1 + number2).ToString();
}

// Учитывая строковые представления двух целых чисел, верните строковое представление суммы этих целых чисел.

// Например: sumStrings('1', '2')  => '3'

// Строковое представление целого числа не будет содержать никаких символов, кроме десяти цифр от "0" до "9".