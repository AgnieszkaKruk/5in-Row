using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5inrow

    {
    public class Game : IGame
    {

        public int[,] Board { get; set; } = new int[5, 5]
        {
           {0,0,0,0,0 },
           {0,0,0,0,0},
           {0,0,0,0,0 },
           {0,0,0,0,0 },
           {0,0,0,0,0 },

        };
        public char current_player_move { get; private set; }

        public List <string> taken_coordinates = new List<string> { };

        public Game(int nRows, int nCols)
        {
            Board = new int[nRows, nCols];
<<<<<<< HEAD
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
=======
        }

        public (int, int) GetMove(int player)
        {
           
            Console.WriteLine("Starting get move");
            
            {
                if (true)
                {
                    
                    Console.WriteLine("List of tsken coordinates: ");
                    foreach (string element in taken_coordinates)
                    {
                        Console.WriteLine(element);
                    }
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
                                if (taken_coordinates.IndexOf(upper_coordinates) != -1)
                                {
                                    Console.WriteLine("you already chose this coordinates.Choose another one:");
                                    return GetMove(player);
                                    
                                }

                                int row = "12345".IndexOf(separate_coordinates[1]);
                                int col = "ABCDE".IndexOf(separate_coordinates[0]);
                                Console.WriteLine("Got it!");

                                Mark(player, row, col);
                                taken_coordinates.Add(upper_coordinates);
                                Console.WriteLine("List of tsken coordinates: ");
                                foreach (string element in taken_coordinates) {
                                    Console.WriteLine(element);
                                }
                                     
                                return (row, col);
                            }

                        }
                    }

                    Console.WriteLine("Invalid coordinates. Try again: ");
                    return GetMove(player);
                } 
            } 
        }
    

        public (int, int) GetAiMove(int player) //
            {
            public int howMany = 5;
            public int EMPTY = 0;

            var empty = new List<(int, int)>();
            var losing = new List<(int, int)>();

            for (int row = 0; row < nRows; row++)
            {
                for (int col = 0; col < nCols; col++)
                {
                    if(Board[row,col] == EMPTY)
                    {
                        (int, int) pos = (row, col);
                        // aktualny stan planszy = przyszly stan planszy ( raz dla 1 gracza, raz dla 2 gracza, potem sprawdzic)
                        // dodac funkcje swith player
                        bool isWinning = HasWon(player, howMany);
                        bool isLosing = HasWon(3 - player, howMany);

                        Board[row, col] = EMPTY;

                        if (isWinning)
                        {
                            return pos;
                        }
                        if (isLosing)
                        {
                            losing.Add(pos);
                        }

                        empty.Add(pos);
                    }
                }
            }

            if (empty.Count > 0)
            {
                return empty[0];
            }

            if (losing.Count> 0)
            {
                return losing[0];
            }
            new Exception("Uppps, board is full. Try again!");
        }


>>>>>>> cee6925639e04e7a7203f7753c6ba9a27fd118d0

        public void Mark(int player, int row, int col)

        {
            Board[row, col] = player;
            PrintBoard();
        }

        public bool HasWon(int player, int howMany)
            {
            int i = 0;
            int j = 0; 
                 
                if(Board[i,j] == player  && Board[i,j+1] == player && Board[i,j+2]== player &&  Board[i,j+3]== player && Board[i,j+4] == player )
                    {
                        Console.WriteLine("Win horizontally");
                        return true;
                    }
                if (Board[i,j] == player && Board[i+1,j] == player && Board[i + 2, j] == player && Board[i + 3, j] == player && Board[i + 4, j] == player)
                    {
                        Console.WriteLine("Win vertically");
                        return true;
                    }
                if (Board[i, j] == player && Board[i + 1, j+1] == player && Board[i + 2, j+2] == player && Board[i + 3, j+3] == player && Board[i + 4, j+4] == player)
                    {
                        Console.WriteLine("Win diagonally+");
                        return true;
                    }
    
                return false;
            }

        public bool IsFull()
        {
            for (int i = 0; i < 5; i++)
            {       
                for (int j = 0; j < 5; j++)
                {
                    if  (Board[i,j] == 0) {
                        Console.WriteLine("Board is not full");
                        return false;
                    }   
                }  
            }
            Console.WriteLine("Board is full");
            return true;
        }
            

            public void PrintBoard()
            {
            var boardLetters = new List<string> { " ", "A", "B", "C", "D", "E" };
            int number = 0;
            foreach (var a in boardLetters)
            {
                Console.Write(a + " | ");
            }
            Console.Write("\n-----------------------\n");

            for (int i = 0; i < 5; i++)
            {
                number++;
                Console.Write(number + " | ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(Board[i, j] + " | ");

                }
                Console.Write("\n-----------------------\n");
            }
        }
        

        public void EnableAi(int player)
            {
            }

        public void Play(int howMany)
        {
            Console.WriteLine("Choose player: 1 or 2?");
            string p = Console.ReadLine();

            int player = Int32.Parse(p);

          

            PrintBoard();

            while (!HasWon(player,howMany))
            {
                GetMove(player);
                if (IsFull()) {
                    Console.WriteLine("end of game- board is full");
                    break;
                }
            }
            PrintResult(player);
        }
            

            public void PrintResult(int player)
            {
            Console.WriteLine("The winnner is: " + player + "!");

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

