// See https://aka.ms/new-console-template for more information
string money = Console.ReadLine();

if (money.Contains(","))
{
    money = money.Replace(",", "");
}
else if (money.Contains("."))
{
    money = money.Replace(".", "");
}

Console.WriteLine(Convert.ToInt32(money));
