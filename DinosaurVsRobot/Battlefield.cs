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
            //Intro for dinos
            GiveRobotWeapon();
            GamePlay();
            //end game notice
            GameOver();

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
                RobotAttackRound();
                //select target
                DinosAttackRound();
                RoundStats();

                
            }
        }
        public void GameOver()
        {
            if (herd.HerdAlive() || fleet.FleetAlive())
            {
                if(herd.HerdAlive())
                {
                    Console.WriteLine("You're on your knees holding onto the bits and pieces left of the robot...\nDinosaurs completely surround you\nGAME OVER");
                }
                else if(fleet.FleetAlive())
                {
                    Console.WriteLine("You not only decimated the immediate dinos that we're threatning you but also went out to cause the extinction of all dinosaurs.\nCongrats you monster!!!");
                }
            }

        }
        public void RoundStats()
        {
            Console.WriteLine("Round Complete!");
            fleet.Robots[0].ReportBotStats();
            fleet.Robots[1].ReportBotStats();
            fleet.Robots[2].ReportBotStats();
            Console.WriteLine("Dinosaur stats");
            herd.Dinos[0].ReportDinoStats();
            herd.Dinos[1].ReportDinoStats();
            herd.Dinos[2].ReportDinoStats();
        }
        public void RobotAttackRound()
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
            else if (fleet.Robots[1].isInWorkingOrder)
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
            else if (fleet.Robots[2].isInWorkingOrder)
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
        }
        public void DinosAttackRound()
        {
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
            else if (herd.Dinos[1].isAlive)
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
            else if (herd.Dinos[2].isAlive)
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
        }
        public void GiveRobotWeapon()
        {
            for (int i = 0; i < fleet.Robots.Count; i++)
            {
                //weapon instantiation for purpose of selection
                Weapon sword = new Weapon("melee", 10);
                Weapon bat = new Weapon("melee", 5);
                Weapon glock = new Weapon("range", 20);

                Console.WriteLine("You will now select the weapon for robot " + fleet.Robots[i].name + ":");
                Console.WriteLine("1) Sword\n2) Bat\n3) Glock");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("A sword?\nTrusty and reliable!\n");
                        fleet.Robots[i].weapon = sword;
                        break;
                    case 2:
                        Console.WriteLine("A bat?\nHow did you even get that here?\n");
                        fleet.Robots[i].weapon = bat;
                        break;
                    case 3:
                        Console.WriteLine("Ah yes...the mighty glock!\n");
                        fleet.Robots[i].weapon = glock;
                        break;
                    default:
                        Console.WriteLine("Your selection did not meet the required inputs (you can only select a number between 1-3)\nStarting selection over.");
                        GiveRobotWeapon();
                        break;

                }
                
            }
        }
    }
    
}
