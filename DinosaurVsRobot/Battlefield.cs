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
            Battlefield newGame = new Battlefield();
            //display welcome message
            DisplayWelcome();
            //introduce robot names
            RobotNameIntros();
            //Next tool to add down the road is ability to add weapon on your own, take a look at stuff David gave you
            GamePlay();
            //end game notice

            


        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to DINO VS ROBOT 3000!\nYou are on the robot team, good luck!\n\n");
        }
        //introduces names of robots to player
        public void RobotNameIntros()
        {
            Console.WriteLine("You are in control of the following robots!");
            Console.WriteLine(fleet.Robots[0].name);
            Console.WriteLine(fleet.Robots[1].name);
            Console.WriteLine(fleet.Robots[2].name);
            Console.WriteLine("\n");
        }
        public void GamePlay()
        {

            while (herd.HerdAlive() && fleet.FleetAlive())
            {
                //Robot attack
                Console.WriteLine("The robots commence an attack");
                if (fleet.Robots[0].isInWorkingOrder)
                {
                    if (herd.Dinos[0].isAlive)
                    {
                        fleet.Robots[0].Attack(herd.Dinos[0]);
                    }
                    else if (herd.Dinos[1].isAlive)
                    {
                        fleet.Robots[0].Attack(herd.Dinos[1]);
                    }
                    else if (herd.Dinos[2].isAlive)
                    {
                        fleet.Robots[0].Attack(herd.Dinos[2]);
                    }
                }
                if (fleet.Robots[1].isInWorkingOrder)
                {
                    if (herd.Dinos[0].isAlive)
                    {
                        fleet.Robots[1].Attack(herd.Dinos[0]);
                    }
                    else if (herd.Dinos[1].isAlive)
                    {
                        fleet.Robots[1].Attack(herd.Dinos[1]);
                    }
                    else if (herd.Dinos[2].isAlive)
                    {
                        fleet.Robots[1].Attack(herd.Dinos[2]);
                    }
                }
                if (fleet.Robots[2].isInWorkingOrder)
                {
                    if (herd.Dinos[0].isAlive)
                    {
                        fleet.Robots[2].Attack(herd.Dinos[0]);
                    }
                    else if (herd.Dinos[1].isAlive)
                    {
                        fleet.Robots[2].Attack(herd.Dinos[1]);
                    }
                    else if (herd.Dinos[2].isAlive)
                    {
                        fleet.Robots[2].Attack(herd.Dinos[2]);
                    }
                }
                //Dinosaurs attack
                Console.WriteLine("The Dinosaurs commence an attack");
                if (herd.Dinos[0].isAlive)
                {
                    if (fleet.Robots[0].isInWorkingOrder)
                    {
                        herd.Dinos[0].Attack(fleet.Robots[0]);
                    
                    }
                    else if (fleet.Robots[1].isInWorkingOrder)
                    {
                        herd.Dinos[0].Attack(fleet.Robots[1]);
                    }
                    else if (fleet.Robots[2].isInWorkingOrder)
                    {
                        herd.Dinos[0].Attack(fleet.Robots[2]);
                    }
                }
                if (herd.Dinos[1].isAlive)
                {
                    if (fleet.Robots[0].isInWorkingOrder)
                    {
                        herd.Dinos[1].Attack(fleet.Robots[0]);
                    }
                    else if (fleet.Robots[1].isInWorkingOrder)
                    {
                        herd.Dinos[1].Attack(fleet.Robots[1]);
                    }
                    else if (fleet.Robots[2].isInWorkingOrder)
                    {
                        herd.Dinos[1].Attack(fleet.Robots[2]);
                    }
                }
                if (herd.Dinos[2].isAlive)
                {
                    if (fleet.Robots[0].isInWorkingOrder)
                    {
                        herd.Dinos[2].Attack(fleet.Robots[0]);
                    }
                    else if (fleet.Robots[1].isInWorkingOrder)
                    {
                        herd.Dinos[2].Attack(fleet.Robots[1]);
                    }
                    else if (fleet.Robots[2].isInWorkingOrder)
                    {
                        herd.Dinos[2].Attack(fleet.Robots[2]);
                    }
                }
                Console.WriteLine("Round Complete!");
                fleet.Robots[0].ReportBotStats();
                fleet.Robots[1].ReportBotStats();
                fleet.Robots[2].ReportBotStats();
                Console.WriteLine("Dinosaur stats");
                herd.Dinos[0].ReportDinoStats();
                herd.Dinos[1].ReportDinoStats();
                herd.Dinos[2].ReportDinoStats();

                //report out battlestats

            }
        }
    }
    
}
