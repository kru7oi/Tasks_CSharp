using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Решение через массивы
        string[,] letters =
        {
            {"А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" },
            {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33" }
        };

        Console.Write("Введите слово для шифрования: ");
        string cypherWord = Console.ReadLine().ToUpper();

        Console.Write("Введите ключ для шифрования: ");
        string cypherKey = Console.ReadLine();

        // Инициализируем массив, который будет хранить зашифрованное слово (без ключа)
        int[] encryptedWord = new int[cypherWord.Length];

        // Ищем совпадение, если есть, то добавляем в массив число
        for (int i = 0; i < cypherWord.Length; i++)
        {
            for (int j = 0; j < letters.Length / 2; j++)
            {
                if (cypherWord[i].ToString() == letters[0, j])
                {
                    encryptedWord[i] = Convert.ToInt32(letters[1, j]);
                }
            }
        }

        // Инициализируем массив, который будет хранить ключ
        int[] code = new int[encryptedWord.Length];

        for (int i = 0, j = 0; i < code.Length; i++, j++)
        {
            // Дублируем ключ
            if (j >= cypherKey.Length)
            {
                j = 0;
            }

            code[i] = Convert.ToInt32(cypherKey[j].ToString());
        }

        // Инициализируем массив зашифрованного слова с ключом
        int[] encryptedWordByKey = new int[encryptedWord.Length];

        // Складываем значение и ключ
        for (int i = 0; i < encryptedWord.Length; i++)
        {
            encryptedWordByKey[i] = encryptedWord[i] + code[i];
        }

        // Выводим на консоль зашифрованное слово с ключом
        Console.WriteLine(string.Join(" ", encryptedWordByKey));
        #endregion

        #region Решение через списки
        //Dictionary<char, int> letters = new Dictionary<char, int>()
        //{
        //    {'А', 1},
        //    {'Б', 2},
        //    {'В', 3},
        //    {'Г', 4},
        //    {'Д', 5},
        //    {'Е', 6},
        //    {'Ё', 7},
        //    {'Ж', 8},
        //    {'З', 9},
        //    {'И', 10},
        //    {'Й', 11},
        //    {'К', 12},
        //    {'Л', 13},
        //    {'М', 14},
        //    {'Н', 15},
        //    {'О', 16},
        //    {'П', 17},
        //    {'Р', 18},
        //    {'С', 19},
        //    {'Т', 20},
        //    {'У', 21},
        //    {'Ф', 22},
        //    {'Х', 23},
        //    {'Ц', 24},
        //    {'Ч', 25},
        //    {'Ш', 26},
        //    {'Щ', 27},
        //    {'Ъ', 28},
        //    {'Ы', 29},
        //    {'Ь', 30},
        //    {'Э', 31},
        //    {'Ю', 32},
        //    {'Я', 33}
        //};

        //Console.Write("Введите слово для шифрования: ");
        //string cypherWord = Console.ReadLine().ToUpper();

        //Console.Write("Введите ключ для шифрования: ");
        //string cypherKey = Console.ReadLine();

        //List<int> encriptedList = new List<int>();
        //var codeList = cypherKey.ToString().Select(x => int.Parse(x.ToString())).ToList();
        //var combinedList = new List<int>();

        //foreach (char c in cypherWord)
        //{
        //    if (letters.ContainsKey(c))
        //    {
        //        encriptedList.Add(letters[c]);
        //    }
        //}

        //while (encriptedList.Count >= codeList.Count)
        //{
        //    codeList.AddRange(codeList);
        //}

        //for (int i = 0; i < encriptedList.Count; i++)
        //{
        //    combinedList.Add(encriptedList[i] + codeList[i]);
        //}

        //foreach (var cl in combinedList)
        //{
        //    Console.WriteLine(cl);
        //}
        #endregion
    }
}