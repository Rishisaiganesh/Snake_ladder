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

            Random random = new Random();
            int die = random.Next(1, 6);
            Console.WriteLine("Your number is:" + die);

        }
    }
}
