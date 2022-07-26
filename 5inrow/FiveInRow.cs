using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5inrow
{
    public class FiveInARow
    {
        public static void Main(string[] args)
        {
            var game = new Game(11, 11);
            game.EnableAi(1);
            game.EnableAi(2);
            game.Play(5);
            game.PrintBoard();
            game.GetMove(2);
            game.IsFull();

            Console.ReadLine();
        }
    }
}
