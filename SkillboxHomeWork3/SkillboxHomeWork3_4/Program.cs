using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHomeWork3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Введи количество чисел в последовательности: ");
                int numbersCount = int.Parse(Console.ReadLine());
                int minNum = int.MaxValue;
                int counter = 1;
                Console.WriteLine("Введите число :");
                while (counter <= numbersCount)
                {

                    int num = int.Parse(Console.ReadLine());
                    if (num < minNum)
                    {
                        minNum = num;
                    }
                    counter++;

                }
                Console.WriteLine("Наименьшее число в вашей последовательности :" + minNum);

            }
        }
    }
}
