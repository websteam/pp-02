using System;
namespace Csharp02
{
    public class WzorAB
    {
        public WzorAB()
        {
            Console.WriteLine("Licz wartość wyrażenia (a*b) / (a+b) ");
            Console.WriteLine("Podaj pierwszą liczbę:");

            int numberA = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            int numberB = int.Parse(Console.ReadLine());

            float solution = (numberA * numberB) / (numberA + numberB);

            Console.WriteLine("Wynik to: {0}", solution);
        }
    }
}
