using System;
namespace Csharp02
{
    public class Usort
    {
        public Usort()
        {
            int[] numbers = new int[3];

            Console.WriteLine("Podaj mi trzy liczby, a ja Ci je posortuję");

            Console.WriteLine("Pierwsza liczba:");
            numbers[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Druga liczba:");
            numbers[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Trzecia liczba:");
            numbers[2] = int.Parse(Console.ReadLine());

            Array.Sort(numbers);

            Console.WriteLine("Liczby w porzadku to: {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
        }
    }
}
