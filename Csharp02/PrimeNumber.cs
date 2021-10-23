using System;
namespace Csharp02
{
    public class PrimeNumber
    {
        public PrimeNumber()
        {
            Console.WriteLine("Sprawdźmy czy liczba jest liczbą pierwszą!");

            Console.WriteLine("Podaj liczbę:");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);

            if (isPrime)
            {
                Console.WriteLine("Podana liczba jest liczbą pierwszą!");
            }
            else
            {
                Console.WriteLine("Podana liczba nie jest liczbą pierwszą :(");
            }
        }

        public bool IsPrime(int n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}
