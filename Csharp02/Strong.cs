using System;
namespace Csharp02
{
    public class Strong
    {
        public Strong()
        {
            int number = ask();

            Console.WriteLine("Silnia z {0} to {1}", number, calculate(number));
        }

        public int ask()
        {
            int number = 0;

            do {
                Console.WriteLine("Liczenie silni. Podaj liczbę z przedziału <1,10>:");
                number = int.Parse(Console.ReadLine());

                if (number < 1 || number > 10)
                {
                    Console.WriteLine("Nie oszukuj! Tylko liczby z przedziału <1,10>. Jeszcze raz.");
                }
            }
            while (number < 1 || number > 10);

            return number;
        }

        public int calculate(int number)
        {
            if (number < 2)
                return 1;

            return number * calculate(number - 1);
        }
    }
}
