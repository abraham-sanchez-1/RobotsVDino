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
            //Next tool to add down the road is ability to add weapon on your own
            //GiveRobotWeapon()
            //jhdlkf

            


        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Hello there, you and your troop of robots have timetraveled 65 million years back in time, you must now face the waves of dinosaurs and turn them extinct or you will perish!");

        }
        //public void GiveRobotWeapon()
        //{
        //    for (int i = 0; i < length; i++)
        //    {

        //    }
        //}
    }
    
}
