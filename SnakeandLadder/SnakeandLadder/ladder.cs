using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeandLadder
{
    class ladder
    {
        public void game()
        {
            Console.WriteLine("Welcome to snake and ladder game ");
            int position = 0;
            Console.WriteLine("The position of player is" + position);
        }
        public void Checkposition()
        {
            Random random = new Random();
            int die = random.Next(1, 6);
            Console.WriteLine("After roll we get the number=" + " " + die);
        }

        int position;
        int Player;
        public void CheckForOption()
        {
            while (Player <= 100)
            {
                Random random = new Random();
                int DieNumber = random.Next(0, 7);
                position = DieNumber;
                if (position == 0)
                {                                           
                    Console.WriteLine("its a no play");
                    Player += position;
                }
                if (Player == 0 && position < 0)
                {
                    Console.WriteLine("its a snake bite ");
                    Player = 0;                              
                }
                if (Player > 0 && position < 0)
                {
                    Console.WriteLine("its a snake bite ");
                    Player += position;
                }
                if (Player > 0)
                {
                    Player = 0;
                }
                if (position > 0)                             
                {
                    Console.WriteLine("its a ladder");
                    Player += position;
                }
            }

            Console.WriteLine("player rolls die and get position " + Player);
        }


        int WinningPosition = 100;
        public void Winposition()
        {
            if (position == WinningPosition)
            {
                Console.WriteLine("U Won the game");
            }
            if (position > WinningPosition)
            {
                Console.WriteLine("Better luckNext time u loss");
            }
            else
                Console.WriteLine("continue the game");

        }
    }
}
