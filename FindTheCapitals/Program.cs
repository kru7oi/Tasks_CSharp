using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindTheCapitals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] r = Capitals("CodEWaRs");

            foreach (int i in r)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] Capitals(string word)
        {
            // Write a function that takes a single non-empty string of only lowercase and uppercase ascii letters(word) as its argument, and returns an ordered list containing the indices of all capital(uppercase) letters in the string.

            // Example(Input-- > Output)
            // "CodEWaRs"-- > [0, 3, 4, 6]

            List<int> result = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }

        //public static int[] Capitals(string word)
        //{
        //    return word.Select((c, i) => Char.IsUpper(c) ? i : -1).Where(i => i >= 0).ToArray();
        //}

        //public static int[] Capitals(string word)
        //{
        //    return Enumerable.Range(0, word.Length).Where(i => char.IsUpper(word, i)).ToArray();
        //}

        //public static int[] Capitals(string word)
        //{
        //    return Regex.Matches(word, "[A-Z]").Select(m => m.Index).ToArray();
        //}
    }
}
