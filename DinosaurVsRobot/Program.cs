using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurVsRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield newGame = new Battlefield();
            newGame.GameRun();

            Console.ReadLine();

        }
    }
}
