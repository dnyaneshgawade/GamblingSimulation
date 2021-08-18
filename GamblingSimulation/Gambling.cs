using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingSimulation
{
    public class Gambling
    {
        public double stack = 100;
        public int bet = 1;
        public void Display()
        {
            Console.WriteLine("\nStack You Have : "+stack+"\nBet Per Game : "+bet);
        }
    }
}
