using System;
namespace Csharp02
{
    public class Calculator
    {
        public Calculator()
        {
            Console.WriteLine("Witaj w kalkulatorze!");

            bool wantsToCalculate = true;

            while(wantsToCalculate)
            {
                Console.WriteLine("Czy chcesz przeprowadzić działanie? Wpisz *koniec* jeśli nie");
                wantsToCalculate = Console.ReadLine().Contains("koniec") ? false : true;

                if (!wantsToCalculate)
                {
                    break;
                }

                Console.WriteLine("Które działanie arytmetyczne chcesz wykonać? (+, -, *, /)");

                string operation = Console.ReadLine();

                Console.WriteLine("Teraz podaj pierwszą liczbę:");
                int numberA = int.Parse(Console.ReadLine());

                Console.WriteLine("Teraz podaj drugą liczbę:");
                int numberB = int.Parse(Console.ReadLine());

                Console.WriteLine("Twój wynik to:");

                switch (operation)
                {
                    case "+": sum(numberA, numberB); break;

                    case "-": subtract(numberA, numberB); break;

                    case "*": multiply(numberA, numberB); break;

                    case "/": divide(numberA, numberB); break;
                }
            }
        }

        public void sum(int numberA, int numberB)
        {
            Console.WriteLine(numberA + numberB);
        }

        public void subtract(int numberA, int numberB)
        {
            Console.WriteLine(numberA - numberB);
        }

        public void multiply(int numberA, int numberB)
        {
            Console.WriteLine(numberA * numberB);
        }

        public void divide(int numberA, int numberB)
        {
            Console.WriteLine(numberA / numberB);
        }
    }
}
