using System;

namespace SnakeandLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wlecome to sanke and ladder game");
            ladder Ladder = new ladder();
            Ladder.game();
            Ladder.CheckForOption();
            Ladder.Winposition();

        }
    }
}
