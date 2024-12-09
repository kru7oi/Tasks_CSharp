using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser
{
    internal class Program
    {
        // Представьте, что вы создаете игру, в которой пользователь должен угадать правильное число.Но существует ограничение на количество возможных угадываний.

        // Если пользователь пытается угадать больше, чем указано в этом ограничении, функция должна выдать ошибку.
        // Если пользователь угадал правильно, она должна вернуть значение true.
        // Если пользователь угадал неверно, он должен вернуть значение false и потерять жизнь.
        // Сможете ли вы завершить игру так, чтобы были соблюдены все правила?
        static void Main(string[] args)
        {
            decimal x = 7 / 5;
            Console.WriteLine(x);
        }
    }

    public class Guesser
    {
        private int number;
        private int lives;
        private int limit;
        private int currentLimit = 1;

        public Guesser(int number, int lives)
        {
            this.number = number;
            this.lives = lives;
            this.limit = lives;
        }

        public bool Guess(int n)
        {
            if (currentLimit > limit)
            {
                throw new Exception("Превышен лимит");
            }

            return false;
        }
    }
}
