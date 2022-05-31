using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerribleTerror
{
    class Roll
    {
        public static int RollTheDice() // генерирует число от 1 до 7(не включительно) на куьиках и вызывает метод который показывает это число на куьиках
        {
            Random random = new Random();
            {
                int number = random.Next(1, 7);
                Dice.PrintDice(number);
                return number;
            }
        }
    }
}
