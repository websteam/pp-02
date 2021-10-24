using System;
namespace Csharp02
{
    public class AvgArray
    {
        public AvgArray()
        {
            Console.WriteLine("Średnia z postępujących liczb! Podaj ilość liczb, a ja wyliczę z nich średnią");

            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            Console.Write("Średnia z liczb ");

            for (int i = 0; i < count; i++)
            {
                numbers[i] = i + 1;

                Console.Write(" {0}", numbers[i]);
            }


            float sum = 0;
            float avg = 0;

            foreach(int number in numbers)
            {
                sum += number;
            }

            avg = sum / count;

            Console.Write(" to {0}", avg);

            // Just a line break
            Console.WriteLine("");
        }
    }
}
