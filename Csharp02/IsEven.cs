using System;
namespace Csharp02
{
    public class IsEven
    {
        public IsEven()
        {
            Console.WriteLine("Podaj liczbę. Sprawdzimy czy jest parzysta!");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta!");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta :(");
            }
        }
    }
}
