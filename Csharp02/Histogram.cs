using System;
namespace Csharp02
{
    public class Histogram
    {
        protected int[] numbers;

        protected int minNumber = 1;

        protected int maxNumber = 5;

        public Histogram()
        {
            Console.WriteLine("Histogram! Podaj ile liczb chcesz wprowadzić:");

            int length = int.Parse(Console.ReadLine());

            numbers = new int[length];

            int current = 0;

            while(current < numbers.Length)
            {
                if (GetNext(current))
                {
                    current++;
                }
            }

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            ConsoleHelper.Exit();
        }

        public bool GetNext(int current)
        {
            Console.WriteLine("Podaj liczbę z przedziału <{0},{1}>", minNumber, maxNumber);

            int input = int.Parse(Console.ReadLine());

            if (input < minNumber && input > maxNumber)
            {
                Console.WriteLine("Tylko liczby z przedziału <{0},{1}>", minNumber, maxNumber);

                return false;
            }

            numbers[current] = input;

            return true;
        }
    }
}
