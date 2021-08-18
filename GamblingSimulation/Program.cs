using System;

namespace GamblingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Gambling Simulation!");
            Gambling gambling = new Gambling();
            gambling.Display();

        }
    }
}
