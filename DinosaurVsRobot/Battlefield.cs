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
            Console.WriteLine("You are an amazing inventor and you have just created a timetravel machine.\nYou are unsure as to whether or not it works but you enter with your loyal robots to test it.\nThe machine transports you back 65 million years and drops you off in a dense jungle.\nThe Timemachine is nowhere to be found and you see leaves ruslting in the distance.\nThree dinasaurs quickly approach, you must now fight to survive!");
        }
        public void GamePlay()
        {
            while()
            {

            }
        }
    }
    
}
