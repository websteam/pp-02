using System;
namespace Csharp02
{
    public class RectangleDrawer
    {
        public RectangleDrawer()
        {
            Console.WriteLine("Narysujmy prostokąt! Podaj wysokość:");

            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj szerokość:");
            int width = int.Parse(Console.ReadLine());

            draw(height, width);
        }

        public void draw(int height, int width)
        {
            for(int i = 0; i < height; i++)
            {
                string[] row = new string[width];

                for (int j = 0; j < width; j++)
                {
                    row[j] = "*";
                }

                Console.WriteLine(String.Join("", row));
            }
        }
    }
}
