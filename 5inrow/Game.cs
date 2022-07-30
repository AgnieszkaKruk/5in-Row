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
           {0,0,0,0,0 },
           {0,0,0,0,0 },
           {0,0,0,0,0 },
           {0,0,0,0,0 },

        };        

        public List <string> takenCoordinates = new List<string> { };

        public Game(int nRows, int nCols)
        {
            
            Board = new int[nRows, nCols]; 
        }

        public (int, int) GetMove(int player)

            

        {
           
            Console.WriteLine("Move player: " + player);
            

            {
                while(true)
                {                   
     
                    Console.Write("Type coordinates e.x. A1 or press q to quit: ");

                    string coordinates = Console.ReadLine(); 
                    if (coordinates != "q")
                    {
                        string upperCoordinates = coordinates.ToUpper();
                        char[] separateCoordinates = upperCoordinates.ToCharArray();
                        if (separateCoordinates.Length == 2)
                        {
                            if (separateCoordinates[0] >= 'A' && separateCoordinates[0] <= 'E')
                            {
                                if (separateCoordinates[1] >= '1' && separateCoordinates[1] <= '5')
                                {
                                    if (takenCoordinates.IndexOf(upperCoordinates) != -1)
                                    {
                                        Console.WriteLine("Coordinates taken.Choose another ones.");
                                        continue;

                                    }
                                    int row = "12345".IndexOf(separateCoordinates[1]);
                                    int col = "ABCDE".IndexOf(separateCoordinates[0]);
                                    Console.WriteLine("Got it!");

                                    Mark(player, row, col);
                                    takenCoordinates.Add(upperCoordinates);
                                    return (row, col);
                                }

                            }
                        }

                        Console.WriteLine("Invalid coordinates. Try again: ");
                        return GetMove(player);
                    }
                    {
                        Environment.Exit(0);
                    }


                } 
            } 
        }
    

        public (int, int) GetAiMove(int player)
            {
            return (0, 0);
            }

        public void Mark(int player, int row, int col)

        {
            Board[row, col] = player;
            PrintBoard();
            
        }

        public bool HasWon(int player, int howMany) // sprawdzic to w petli skrocic zapis
            {
            int i = 0;
            int j = 0; 
                 
                if(Board[i,j] == player  && Board[i,j+1] == player && Board[i,j+2]== player &&  Board[i,j+3]== player && Board[i,j+4] == player )
                    {
                        Console.WriteLine("Win horizontally!");
                        return true;
                    }
                if (Board[i,j] == player && Board[i+1,j] == player && Board[i + 2, j] == player && Board[i + 3, j] == player && Board[i + 4, j] == player)
                    {
                        Console.WriteLine("Win vertically!");
                        return true;
                    }
                if (Board[i, j] == player && Board[i + 1, j+1] == player && Board[i + 2, j+2] == player && Board[i + 3, j+3] == player && Board[i + 4, j+4] == player)
                    {
                        Console.WriteLine("Win diagonally!");
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
                    Console.WriteLine("End of game - board is full");
                    break;
                }
                if (player == 1)
                {
                    player = 2;
                }
                else
                {
                    player = 1;
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

