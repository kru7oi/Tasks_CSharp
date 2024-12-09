using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGhost
{
    internal class Program
    {
        // Создайте класс Ghost

        // Объекты-призраки создаются без каких-либо аргументов.

        // Объектам-призракам присваивается случайный атрибут цвета "белый", "желтый", "фиолетовый" или "красный" при создании экземпляра

        // ghost = new Ghost();
        // ghost.color //=> "белый", или "желтый", или "фиолетовый", или "красный"
        static void Main(string[] args)
        {
            Ghost ghost1 = new Ghost();
            Console.WriteLine(ghost1.color);

            Ghost ghost2 = new Ghost();
            Console.WriteLine(ghost2.color);
        }

        public class Ghost
        {
            public Ghost()
            {
                SetColor();
            }

            private string[] colors = new string[] { "white", "yellow", "purple", "red" };
            public string color;

            private void SetColor()
            {
                Random random = new Random();

                color = colors[random.Next(1, colors.Length)];
            }
        }
    }
}
