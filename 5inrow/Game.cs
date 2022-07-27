using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5inrow

    {
        public class Game : IGame
        {
            public int[,] Board { get; set; }

            public Game(int nRows, int nCols)
            {
            Board = new int[nRows, nCols];
            }

            public (int, int) GetMove(int player)
            {
            
            

            while (true) {
                Console.Write("Type coordinates e.x. A1: ");
                string coordinates = Console.ReadLine();
                string upper_coordinates = coordinates.ToUpper();
                char[] separate_coordinates = upper_coordinates.ToCharArray();
                if (separate_coordinates.Length == 2)
                {
                    if (separate_coordinates[0] == 'A' || separate_coordinates[0] == 'B' || separate_coordinates[0] == 'C' || separate_coordinates[0] == 'D' ||
    separate_coordinates[0] == 'E')
                    {
                        if (separate_coordinates[1] == '1' || separate_coordinates[1] == '2' || separate_coordinates[1] == '3' || separate_coordinates[1] == '4' ||
    separate_coordinates[1] == '5')
                        {
                            int row = "12345".IndexOf(separate_coordinates[1]);
                            int col = "ABCDE".IndexOf(separate_coordinates[0]);
                            Console.WriteLine("Got it!");
                            return (row, col);
                        }
                    }
                }
                Console.WriteLine("Invalid coordinates. Try again: ");
                Console.WriteLine("Invalid coordinates. Try again: ");
                coordinates = Console.ReadLine();                
            }
            
        }

        public (int, int) GetAiMove(int player)
            {
            return (0, 0);
        }

            public void Mark(int player, int row, int col)
            {
            }

            public bool HasWon(int player, int howMany)
            {
                return false;
            }

            public bool IsFull()
            {
                return false;
            }

            public void PrintBoard()
            {
            var board = new List<string> { ".", ".", ".", ".", "." };
            var boardLetters = new List<string> { " ", "A", "B", "C", "D", "E" };
            var bigboard = new List<List<string>> { };
            bigboard.Add(boardLetters);
            bigboard.Add(board);
            bigboard.Add(board);
            bigboard.Add(board);
            bigboard.Add(board);
            int number = 0;
            foreach (var a in boardLetters)
            {
                Console.Write(a + " | ");
            }


            Console.Write("\n-----------------------\n");
            foreach (var inboard in bigboard)
            {
                number++;

                Console.Write(number + " | ");
                foreach (var b in board)
                {
                    Console.Write(b + " | ");

                }


                Console.Write("\n-----------------------\n");

            }

        }

        public void EnableAi(int player)
            {
            }

            public void Play(int howMany)
            {
            }

            public void PrintResult(int player)
            {
            }
        }

        /* DO NOT CHANGE THIS INTERFACE! It will be used to test your solution. */
        public interface IGame
        {
            int[,] Board { get; set; }
            (int, int) GetMove(int player);
            (int, int) GetAiMove(int player);
            void Mark(int player, int row, int col);
            bool HasWon(int player, int howMany);
            bool IsFull();
            void PrintBoard();
            void PrintResult(int player);
            void EnableAi(int player);
            void Play(int howMany);
        }
    }

