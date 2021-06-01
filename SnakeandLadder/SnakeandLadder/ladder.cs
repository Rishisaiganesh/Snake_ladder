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
            Console.WriteLine("u want continue the game y/n");
            String value = Convert.ToString(Console.ReadLine());
            if (value == "y")

            {
                int answer = random.Next(1, 2);
                switch (answer)
                {
                    case 1:
                        position = position + die;
                        Console.WriteLine("You get a ladder step to" + position);
                        break;
                    case 2:
                        if (position < 0) ;
                        {
                            Console.WriteLine("You lost the game");
                        }
                        else
                            {
                                position = position - die;
                            }

                            Console.WriteLine("......Snake bits>>>> you" + position);
                            break;
                            default:
                        Console.WriteLine("NO position");
                            break;


                        }

                }
            else
            {
                Console.WriteLine("if u press n the position " +position);
            }

            }
        }
    }


