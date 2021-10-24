using System;
namespace Csharp02
{
    public class Menu
    {
        protected string[] options = new string[]
        {
            "Nowa gra",
            "Informacje o autorze",
            "Wyjście"
        };

        public Menu()
        {
            DrawMenu();
        }

        public void NewGame()
        {
            Console.Clear();

            Console.WriteLine("Nowa gra");

            BackToMenu();
        }

        public void AuthorInfo()
        {
            Console.Clear();

            Console.WriteLine("Informacje o autorze:");
            Console.WriteLine("Mateusz Korbanek");
            Console.WriteLine("Grupa k29");

            BackToMenu();
        }

        public void Exit()
        {
            Console.Clear();

            Console.WriteLine("Czy na pewno chcesz wyjść? <enter>");

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Dziękuję, dobranoc!");
                    break;
                default:
                    BackToMenu();
                    break;
            }
        }

        public void BackToMenu()
        {
            Console.WriteLine("Naciśnik <enter> aby wrócić do menu...");

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    DrawMenu();
                    break;
                default:
                    Console.WriteLine("Powiedziałem enter!");

                    BackToMenu();
                    break;
            }
        }

        public void DrawMenu()
        {
            Console.Clear();

            Console.WriteLine("Wyberz opcję:");

            for(int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("{0}) {1}", i + 1, options[i]);
            }

            ChooseOption();
        }

        public void ChooseOption()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    NewGame();
                    break;
                case ConsoleKey.D2:
                    AuthorInfo();
                    break;
                case ConsoleKey.D3:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja!");

                    ChooseOption();
                    break;
            }
        }
    }
}
