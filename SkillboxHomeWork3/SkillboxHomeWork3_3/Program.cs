using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHomeWork3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Введите число :");
                int number = int.Parse(Console.ReadLine());
                int counter = 2;
                bool isPrime = true;

                if (number == 1 || number == 0)
                {
                    Console.WriteLine($" Число {number} не является ни простым , ни составным !!!");
                    
                }
                else
                {

                    while (counter < number)
                    {
                        if (number % counter == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        else

                        counter++;
                    }


                    if (isPrime == true)
                    {
                        Console.WriteLine("Число " + number + " простое.");
                    }
                    else
                    {
                        Console.WriteLine("Число " + number + " НЕ простое.");
                    }
                }

            }
        }
    }
}
