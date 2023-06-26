using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHomeWork3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите число : ");
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine("Ноль — чётное число!");
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine("Число " + number + " - чётное!!!");
                }
                else Console.WriteLine("Число " + number + " - нечётное!!!");
            }
        }
    }
}
