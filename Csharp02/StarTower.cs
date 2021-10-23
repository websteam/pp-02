using System;
namespace Csharp02
{
    public class StarTower
    {
        public StarTower()
        {
            Console.WriteLine("Narysujmy wieżę z gwiazdek! Podaj wysokość:");

            int height = int.Parse(Console.ReadLine());

            draw(height);
        }

        public void draw(int height)
        {
            for (int x = 0; x < height * 2; x += 2)
            {
                for (int y = (height * 2) - x; y > 0; y -= 2)
                {
                    Console.Write(" ");
                }
                for (int z = 0; z <= x; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}
