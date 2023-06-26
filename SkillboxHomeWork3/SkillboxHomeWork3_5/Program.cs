using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHomeWork3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите максимальное число: ");
            int numMax;
            int counter=0;
            int.TryParse(ReadLine(),out numMax);
            Random rand = new Random();
            int hidedNum = rand.Next(numMax);
            WriteLine("Попробуй угадать число (нажми Enter для выхода)");
            while (true)
            {

                string userString = ReadLine();
                counter++;
                if (string.IsNullOrEmpty(userString))
                {
                    WriteLine("Загаданое число : " + hidedNum);
                    ReadKey();

                    break;
                }
                int userNumber = int.Parse(userString);
                if (userNumber > hidedNum)
                {
                    WriteLine("Ваше число больше");
                }
                else
                if (userNumber != hidedNum)
                {
                    WriteLine("Ваше число меньше");
                }
                else if (userNumber == hidedNum)
                {
                    WriteLine($"Поздравляю, Вы угадали за {counter} попыток");
                    
                    break;
                }
                else
                { }
            }
        }
    }
}
