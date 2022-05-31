using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerribleTerror
{
    class Dice
    {
        public static void PrintDice(int number) // варианты кубиков
        {

            switch (number)
            {
                case 1:
                    Console.WriteLine("---------");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|   #   |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("---------");
                    break;
                case 2:
                    Console.WriteLine("---------");
                    Console.WriteLine("| #     |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|     # |");
                    Console.WriteLine("---------");
                    break;
                case 3:
                    Console.WriteLine("---------");
                    Console.WriteLine("| #     |");
                    Console.WriteLine("|   #   |");
                    Console.WriteLine("|     # |");
                    Console.WriteLine("---------");
                    break;
                case 4:
                    Console.WriteLine("---------");
                    Console.WriteLine("| #   # |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("| #   # |");
                    Console.WriteLine("---------");
                    break;
                case 5:
                    Console.WriteLine("---------");
                    Console.WriteLine("| #   # |");
                    Console.WriteLine("|   #   |");
                    Console.WriteLine("| #   # |");
                    Console.WriteLine("---------");
                    break;
                case 6:
                    Console.WriteLine("---------");
                    Console.WriteLine("| # # # |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("| # # # |");
                    Console.WriteLine("---------");
                    break;
            }
        }
    }
}
