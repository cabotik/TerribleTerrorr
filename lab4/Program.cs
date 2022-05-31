using System;

namespace TerribleTerror
{
    class General
    {
        public void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Для начала введите *");
                if (Console.ReadLine() == "*")
                {
                    StartGame();
                }
                else
                {
                    return;
                }
            }
        }
        public void StartGame()
        {
            Console.WriteLine("Игра “Три кубика”");
            Console.WriteLine("Правила игры: Бросают три кости, выигрывает тот игрок, у которого сумма выпавших очков равнялась одному из двух чисел, названных им перед началом игры.Например, игрок назвал 7 и 13, и один из его удачных бросков показан на рисунке.");
            MainAction mainAction = new();
            string Action = mainAction.Result(1);
            Console.WriteLine(Action);


        }
    }
    public class MainAction
    {
        public string Result(int number) // ввод чисел, генерация резьтатов броска
        {
            int predict1;
            Console.Write("Ведите первое число: ");
            if (!Int32.TryParse(Console.ReadLine(), out predict1))
            {
                do
                {
                    Console.WriteLine("Ошибка! Попробуйте еще раз.");
                    Console.Write("Ведите первое число: ");
                } while (!Int32.TryParse(Console.ReadLine(), out predict1));
            }
            int predict2;
            Console.Write("Ведите второе число: ");
            if (!Int32.TryParse(Console.ReadLine(), out predict2))
            {
                do
                {
                    Console.WriteLine("Ошибка! Попробуйте еще раз.");
                    Console.Write("Ведите второе число: ");
                } while (!Int32.TryParse(Console.ReadLine(), out predict2));
            }
            int number1 = Roll.RollTheDice();
            int number2 = Roll.RollTheDice();
            int number3 = Roll.RollTheDice();
            string countAndRsult = CountAndResult(number1, number2, number3, predict1, predict2);
            Console.WriteLine(countAndRsult);
            return "";
        }
        public string CountAndResult(int number1, int number2, int number3, int predict1, int predict2)
        {
            int sum = number1 + number2 + number3;
            if (sum == predict1)
            {
                return "Вы выйграли!";
            }
            else if (sum == predict2)
            {
                return "Вы выйграли!";
            }
            else
            {
                return "Вы проиграли!";
            }
        }
    }
}
