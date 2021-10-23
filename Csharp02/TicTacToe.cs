using System;
namespace Csharp02
{
    public class TicTacToe
    {
        char[,] board = new char[3, 3] {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        int[,,] possibleSolutions = new int[8, 3, 2]
        {
            { {0, 0}, {0, 1}, {0, 2} },
            { {1, 0}, {1, 1}, {1, 2} },
            { {2, 0}, {2, 1}, {2, 2} },

            { {0, 0}, {1, 0}, {2, 0} },
            { {0, 1}, {1, 1}, {2, 1} },
            { {0, 2}, {1, 2}, {2, 2} },

            { {0, 0}, {1, 1}, {2, 2} },
            { {2, 0}, {1, 1}, {0, 2} },
        };

        public const char x = 'x';

        public const char o = 'o';

        public const char empty = ' ';

        public bool isPlaying = true;

        // true = x, false = o
        public bool whoIsPlaying = true;

        public bool isValidMove = false;

        public bool doAgain = false;

        public char winner;

        public TicTacToe()
        {
            Console.WriteLine("Witaj w grze w kółko i krzyżyk!");

            Console.WriteLine("Oto plansza i możliwe na niej ruchy:");
            DrawBoard();

            Game();
        }

        public void Game()
        {
            if (!doAgain)
            {
                Console.WriteLine("Zaczynamy? (cokolwiek = tak, n = nie)");
            }
            else
            {
                Console.WriteLine("Jeszcze raz? (cokolwiek = tak, n = nie)");
            }

            bool doWeStart = Console.ReadLine().Contains('n') ? false : true;

            if (!doWeStart)
            {
                Console.WriteLine("Okej, pa.");
                return;
            }

            EmptyBoard();
            DrawBoard();

            while (isPlaying)
            {
                while (!isValidMove)
                {
                    if (whoIsPlaying == true)
                    {
                        XMove();
                    }
                    else
                    {
                        OMove();
                    }

                    if (!isValidMove)
                    {
                        Console.WriteLine("Ruch nieprawidłowy! Spróbuj jeszcze raz.");
                    }
                }

                if (CheckGameState())
                {
                    Console.WriteLine("Koniec gry! Wygrał {0}. Gratulacje!");

                    isPlaying = false;
                }

                DrawBoard();
                isValidMove = false;
            }

            doAgain = true;
            isPlaying = true;
            Game();
        }

        public bool CheckGameState()
        {
            for (int i = 0; i < 8; i++)
            {
                string solution = "";

                for (int j = 0; j < 3; j++)
                {
                    int indexX = possibleSolutions[i, j, 0];
                    int indexY = possibleSolutions[i, j, 1];

                    char value = board[indexX, indexY];

                    solution += value;
                }

                if (solution.Equals("xxx"))
                {
                    winner = x;

                    return true;
                }

                if (solution.Equals("ooo"))
                {
                    winner = o;

                    return true;
                }
            }

            // False means game isn't over yet
            return false;
        }

        public void XMove()
        {
            Console.WriteLine("Ruch X: ");

            Move(x);
        }

        public void OMove()
        {
            Console.WriteLine("Ruch O: ");

            Move(o);
        }

        public void Move(char who)
        {
            int where = int.Parse(Console.ReadLine());

            if (where < 1 && where > 9)
            {
                Console.WriteLine("Nie oszukuj! Tylko cyfry z zakresu <1,9>");
                isValidMove = false;
                goto endmove;
            }

            var boardValue = getValue(where);

            if (boardValue.Equals(x) || boardValue.Equals(o))
            {
                Console.WriteLine("Nie możesz wykonać tego ruchu!");
                isValidMove = false;
                goto endmove;
            }

            SetValue(where, who);

            whoIsPlaying = !whoIsPlaying;
            isValidMove = true;

        endmove:
            return;
        }

        public char getValue(int where)
        {
            return where switch
            {
                1 => board[0, 0],
                2 => board[0, 1],
                3 => board[0, 2],
                4 => board[1, 0],
                5 => board[1, 1],
                6 => board[1, 2],
                7 => board[2, 0],
                8 => board[2, 1],
                9 => board[2, 2],
                _ => ' ',
            };
        }

        public dynamic SetValue(int where, char value)
        {
            return where switch
            {
                1 => board[0, 0] = value,
                2 => board[0, 1] = value,
                3 => board[0, 2] = value,
                4 => board[1, 0] = value,
                5 => board[1, 1] = value,
                6 => board[1, 2] = value,
                7 => board[2, 0] = value,
                8 => board[2, 1] = value,
                9 => board[2, 2] = value,
                _ => ' ',
            };
        }

        public void DrawBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", board[i, j]);

                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                }

                Console.WriteLine("");

                if (i < 2)
                {
                    Console.WriteLine("---+---+---");
                }
            }
        }

        public void EmptyBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = empty;
                }
            }
        }
    }
}
