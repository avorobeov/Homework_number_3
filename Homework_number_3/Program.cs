using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;

            while (isExit == false)
            {
                string neme;
                string zodiacSign;
                string placeWork;

                int age;
                int minimumAge = 7;

                Console.Write("Укажите ваше имя: ");
                neme = Console.ReadLine();

                Console.Write("Укажите ваш знак зодиака: ");
                zodiacSign = Console.ReadLine();

                Console.Write("Укажите где вы работаете: ");
                placeWork = Console.ReadLine();

                Console.Write("Укажите сколько вам лет: ");
                age = Convert.ToInt32(Console.ReadLine());

                if (neme != "" && zodiacSign != "" && placeWork != "" && age > minimumAge)
                {
                    Console.Write($"Вас зовут {neme}, вам {age} год, вы {zodiacSign} и работаете на {placeWork}.");

                    Console.ReadKey();

                    isExit = true;
                }
                else
                {
                    Console.Write("Одно из полей указано не верно попробуйте указать ещё раз\n");
                }
            }
        }
    }
}
