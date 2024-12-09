using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHighestProfitWins
{
    internal class Program
    {
        // История
        // У Бена есть очень простая идея, как получить некоторую прибыль: он покупает что-то и снова продает.Конечно, это не принесло бы ему никакой прибыли, если бы он просто покупал и продавал это по одной и той же цене. Вместо этого он собирается купить его по как можно более низкой цене и продать по самой высокой.

        // Задача
        // Напишите функцию, которая возвращает как минимальное, так и максимальное число из заданного списка/массива.

        // Примеры (Ввод -> Вывод)
        // [1, 2, 3, 4, 5] --> [1, 5]
        // [2334454, 5] --> [5, 2334454]
        // [1]         --> [1, 1]

        // Замечания
        // Все массивы или списки всегда будут содержать хотя бы один элемент, поэтому вам не нужно проверять длину.Кроме того, ваша функция всегда будет получать массив или список, вам не нужно проверять наличие null, undefined или подобных элементов.

        static void Main(string[] args)
        {
            foreach (int i in MinMax(new int[] { 1, 2, 5, -1, 12, 20 }))
            {
                Console.WriteLine(i);
            }
        }
        public static int[] MinMax(int[] list)
        {
            List<int> result = new List<int>();

            result.Add(list.Min());
            result.Add(list.Max());

            return result.ToArray();
        }

        //public static int[] minMax(int[] lst)
        //{
        //    return new int[] { lst.Min(), lst.Max() };
        //}

        //public static int[] minMax(int[] lst)
        //{
        //    int min = lst[0];
        //    int max = lst[0];
        //    foreach (int num in lst)
        //    {
        //        if (num > max)
        //        {
        //            max = num;
        //        }
        //        if (num < min)
        //        {
        //            min = num;
        //        }
        //    }
        //    return new int[] { min, max };
        //}

        //public static int[] minMax(int[] lst)
        //{
        //    Array.Sort(lst);
        //    return new int[] { lst[0], lst[^1] };
        //}
    }
}
