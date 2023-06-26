using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHomeWork3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string game = "y";
            int aces= 0;
            while (game == "y")
            {




                Console.WriteLine("Здравствуйте! Сколько карт у Вас на руках? :");

                int cardsCount;
                while (!(int.TryParse(Console.ReadLine(), out cardsCount))) 
                { 
                    Console.WriteLine("Сколько карт у Вас на руках (цифрами) ? : ");
                }
                

                int sumPoints = 0;
                Console.WriteLine("Валет = J, Дама = Q, Король = K, Туз = A");
                for (int i = 0; i < cardsCount; i++)
                {
                    Console.WriteLine("Введите карту " + (i + 1) + " :");
                    string card = Console.ReadLine().ToLower();
                    if (card == "j"| card == "q" | card == "k")
                    {
                        sumPoints +=10;
                    }
                    else if (card == "a")
                    {
                        sumPoints = sumPoints + 11;
                        aces++;
                    }
                    else
                    {
                        if (card == "0"|!int.TryParse(card,out _))
                        {
                            Console.WriteLine(" Нет такой карты ");
                        }
                        else sumPoints += int.Parse(card);

                    }

                }
                if (sumPoints == 22 & aces == 2)
                {
                    Console.WriteLine(" У вас ОЧКО(пара тузов), поздравляю!!!");
                }
                else
                {
                    Console.WriteLine(" Сумма ваших карт составляет : " + sumPoints);
                    Random randomize = new Random();
                    int dealer = randomize.Next(15, 25);

                    if (sumPoints > 21)

                    {
                        Console.WriteLine("ПЕРЕБОР!!!");

                    }
                    else if (sumPoints == 21)
                    {
                        Console.WriteLine("ОЧКО, поздравляю!!!");
                    }
                }


                Console.WriteLine("Хотите продолжить? (Y/N): ");
                aces = 0;
                game = Console.ReadLine().ToLower();
            }
            }
    }
}
