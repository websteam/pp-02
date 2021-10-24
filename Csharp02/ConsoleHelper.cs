using System;
namespace Csharp02
{
    public class ConsoleHelper
    {
        public ConsoleHelper()
        {
        }

        public static bool Exit()
        {
            Console.WriteLine("Naciśnik <enter> aby wyjść...");

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Powiedziałem enter!");
                    return true;
                default:
                    Exit();
                    break;
            }

            return false;
        }
    }
}
