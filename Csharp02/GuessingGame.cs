using System;
namespace Csharp02
{
    public class GuessingGame
    {
        protected string[] players;

        protected int[] numbers;

        protected Random seed = new Random();

        protected int minContestants = 1;

        protected int maxContestants = 5;

        protected string winner;

        protected int currentPlayer = 0;

        public GuessingGame()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("#     WITAJ W ZGADUJ-ZGADULI     #");
            Console.WriteLine("##################################");

            IntroduceContestants();

            Play();
        }

        public void Play()
        {
            Console.Clear();

            while (winner == null)
            {
                Console.WriteLine("Zgaduje {0}:", players[currentPlayer]);

                int input = int.Parse(Console.ReadLine());

                bool playerGuess = Guess(numbers[currentPlayer], input);

                if (!playerGuess)
                {
                    currentPlayer++;

                    if (currentPlayer > players.Length - 1)
                    {
                        currentPlayer = 0;
                    }

                    continue;
                }

                winner = players[currentPlayer];
            }

            Console.WriteLine("Super! Mamy zwycięzcę! Gratulacje dla {0}", winner);

            Console.WriteLine("Liczby jakie wylosowaliście to:");

            for(int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("{0} - {1}", players[i], numbers[i]);
            }

            Console.WriteLine("Wanna play again? (t = tak, cokolwiek = nie)");

            bool playAgain = Console.ReadLine().Contains('t');

            if (playAgain)
            {
                Play();
            }
            else
            {
                Console.WriteLine("Dzięki! Papa.");
            }
        }

        public bool Guess(int actual, int guessed)
        {
            if (guessed < actual)
            {
                Console.WriteLine("Za mała!");

                return false;
            }
            else if (guessed > actual)
            {
                Console.WriteLine("Za duża!");

                return false;
            }

            return true;
        }

        public void IntroduceContestants()
        {
            Console.WriteLine("Ilu uczestników będzie brało udział w zabawie? (1-5)");

            int numberOfContestants = 0;

            while (numberOfContestants < 1)
            {
                int input = int.Parse(Console.ReadLine());

                if (input < minContestants || input > maxContestants)
                {
                    Console.WriteLine("Błąd! Prawidłowa liczba uczestników to 1-5");
                    continue;
                }

                numberOfContestants = input;
            }

            players = new string[numberOfContestants];
            numbers = new int[numberOfContestants];

            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("Wprowadź imię {0} zawodnika", i + 1);

                string name = Console.ReadLine();

                players[i] = name;
                numbers[i] = RandomNumber();
            }

            Console.WriteLine("Super! Oto nasi uczestnicy:");

            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("{0}", players[i]);
            }
        }

        public int RandomNumber()
        {
            return seed.Next(1, 100);
        }
    }
}
