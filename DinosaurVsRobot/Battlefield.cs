using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurVsRobot
{
    class Battlefield
    {
        //member variables
        Herd herd;
        Fleet fleet;

        //constructor
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

        //member methods
        public void GameRun()
        {
            //display welcome message
            DisplayWelcome();
            //Next tool to add down the road is ability to add weapon on your own, take a look at stuff David gave you
            //GamePlay();
            //end game notice

            


        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to DINO VS ROBOT 3000!\nYou are on the robot team, good luck!");
        }
        public void GamePlay()
        {
            while(herd.HerdAlive() && fleet.FleetAlive())
            {
                Console.WriteLine("The robots commence an attack");
                for (int i = 0; i < ; i++)
                {
                    if (true)
                    {

                    }
                }
                
            }
        }
    }
    
}
