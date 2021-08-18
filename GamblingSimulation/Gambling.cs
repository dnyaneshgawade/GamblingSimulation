using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingSimulation
{
    public class Gambling
    {
        public double stack = 100;
        public int bet = 1;
        public void Gamble()
        {
            Random random = new Random();
            int num = random.Next(0,2);
            if (num == 0)
            {
                Console.WriteLine("you win");
                stack += 1;
                Console.WriteLine("Stack after winning : "+stack);
            }
            if (num == 1)
            {
                Console.WriteLine("you loss");
                stack -= 1;
                Console.WriteLine("Stack after loosing : " + stack);
            }
        }
    }
}
