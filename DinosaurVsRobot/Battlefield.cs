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
            RobotNameIntros();
            DinoNameIntros();
            GiveRobotWeapon();
            GamePlay();
            GameOver();

        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to DINO VS ROBOT 3000: The Ultimate in battle simulation!\n\n");
            Console.WriteLine("Click any key to continue");
            Console.ReadLine();
        }
        public void RobotNameIntros()
        {
            Console.WriteLine("The robot team is composed of the following robots!");
            Console.WriteLine(fleet.Robots[0].name);
            Console.WriteLine(fleet.Robots[1].name);
            Console.WriteLine(fleet.Robots[2].name);
            Console.WriteLine("\n");
            Console.WriteLine("Click any key to continue");
            Console.ReadLine();
        }
        public void DinoNameIntros()
        {
            Console.WriteLine("The Dinosaur team is composed of the following types!");
            Console.WriteLine(herd.Dinos[0].type);
            Console.WriteLine(herd.Dinos[1].type);
            Console.WriteLine(herd.Dinos[2].type);
            Console.WriteLine("\n");
            Console.WriteLine("Click any key to continue");
            Console.ReadLine();
        }
        public void GamePlay()
        {

            while (herd.HerdAlive() && fleet.FleetAlive())
            {
                RobotAttackDinoRound();
                DinoAttackRobotRound();
                //RobotAttackRound();
                //select target
                //DinosAttackRound();
                //RoundStats();

                
            }
        }
        public void GameOver()
        {
            if (herd.HerdAlive() || fleet.FleetAlive())
            {
                if(herd.HerdAlive())
                {
                    Console.WriteLine("You're on your knees holding onto the bits and pieces left of the robots...\nDinosaurs completely surround you\nGAME OVER");
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
        public void RobotAttackDinoRound()
        {
            int SelectedDino = SelectDinosaurToAttack();
            int SelectedRobot = SelectRobotThatAttacks();

            fleet.Robots[SelectedRobot].Attack(herd.Dinos[SelectedDino]);
        }
        public void DinoAttackRobotRound()
        {
            int SelectedRobot = SelectRobotToAttack();
            int SelectedDino = SelectDinoThatAttacks();

            herd.Dinos[SelectedDino].Attack(fleet.Robots[SelectedRobot]);
        }
        public int SelectRobotToAttack()
        {
            int robotNumber = 0;

            Console.WriteLine("Select dinosaur to attack:");
            Console.WriteLine("1) Assaultron: Status " + IsRobotSelectedAlive(0));
            Console.WriteLine("2) Liberty-Prime: Status " + IsRobotSelectedAlive(1));
            Console.WriteLine("3) Sentry-Bot: Status " + IsRobotSelectedAlive(2));
            int UserSelection = int.Parse(Console.ReadLine());

            switch (UserSelection)
            {
                case 1:
                    if (!fleet.Robots[0].isInWorkingOrder)
                    {
                        Console.WriteLine(fleet.Robots[0].name + " is not alive.");
                        SelectRobotToAttack();
                    }
                    else
                    {
                        Console.WriteLine(fleet.Robots[0].name + " has been selected!");
                        robotNumber = 0;
                    }
                    break;
                case 2:
                    if (!fleet.Robots[1].isInWorkingOrder)
                    {
                        Console.WriteLine(fleet.Robots[1].name + " is not alive.");
                        SelectRobotToAttack();
                    }
                    else
                    {
                        Console.WriteLine(fleet.Robots[1].name + " has been selected!");
                        robotNumber = 1;
                    }
                    break;
                case 3:
                    if (!fleet.Robots[2].isInWorkingOrder)
                    {
                        Console.WriteLine(fleet.Robots[2].name + " is not alive.");
                        SelectRobotToAttack();
                    }
                    else
                    {
                        Console.WriteLine(fleet.Robots[2].name + " has been selected!");
                        robotNumber = 2;
                    }
                    break;
                default:
                    Console.WriteLine("Your selection was outside of 1-3, select again.");
                    SelectRobotToAttack();
                    break;

            }
            return robotNumber;
        }
        public int SelectDinoThatAttacks()
        {
            int dinoNumber = 0;

            Console.WriteLine("Select robot to complete attack:");
            Console.WriteLine("1) T-Rex: Status " + IsDinoSelectedAlive(0));
            Console.WriteLine("2) Velociraptor: Status " + IsDinoSelectedAlive(1));
            Console.WriteLine("3) Triceratops: Status " + IsDinoSelectedAlive(2));
            int UserSelection = int.Parse(Console.ReadLine());

            switch (UserSelection)
            {
                case 1:
                    if (!herd.Dinos[0].isAlive)
                    {
                        Console.WriteLine(herd.Dinos[0].type + " is not alive.");
                        SelectDinoThatAttacks();
                    }
                    else
                    {
                        Console.WriteLine(herd.Dinos[0].type + " has been selected!");
                        dinoNumber = 0;
                    }
                    break;
                case 2:
                    if (!herd.Dinos[1].isAlive)
                    {
                        Console.WriteLine(herd.Dinos[1].type + " is not alive.");
                        SelectDinoThatAttacks();
                    }
                    else
                    {
                        Console.WriteLine(herd.Dinos[1].type + " has been selected!");
                        dinoNumber = 1;
                    }
                    break;
                case 3:
                    if (!herd.Dinos[2].isAlive)
                    {
                        Console.WriteLine(herd.Dinos[2].type + " is not alive.");
                        SelectDinoThatAttacks();
                    }
                    else
                    {
                        Console.WriteLine(herd.Dinos[2].type + " has been selected!");
                        dinoNumber = 2;
                    }
                    break;
                default:
                    Console.WriteLine("Your selection was outside of 1-3, select again.");
                    SelectDinoThatAttacks();
                    break;

            }
            return dinoNumber;
        }
        public string IsDinoSelectedAlive(int SelectedDino)
        {
            int DinoSelected;
            DinoSelected = SelectedDino;

            if(herd.Dinos[DinoSelected].isAlive)
            {
                return "Alive with " + herd.Dinos[DinoSelected].health + " health points left";
            }
            else
            {
                return "KNOCKED OUT";
            }
        }
        public string IsRobotSelectedAlive(int SelectedRobot)
        {
            int RobotSelected;
            RobotSelected = SelectedRobot;

            if (fleet.Robots[RobotSelected].isInWorkingOrder)
            {
                return "Alive with " + fleet.Robots[RobotSelected].health + " health points left";
            }
            else
            {
                return "KNOCKED OUT";
            }
        }
        public int SelectDinosaurToAttack()
        {
            int dinosaurNumber = 0;

            Console.WriteLine("Select dinosaur to attack:");
            Console.WriteLine( "1) T-Rex: Status: " + IsDinoSelectedAlive(0));
            Console.WriteLine("2) Velociraptor: Status: " + IsDinoSelectedAlive(1));
            Console.WriteLine("3) Triceratops: Status: " + IsDinoSelectedAlive(2));
            int UserSelection = int.Parse(Console.ReadLine());

            switch (UserSelection)
            {
                case 1:
                    if (!herd.Dinos[0].isAlive)
                    {
                        Console.WriteLine(herd.Dinos[0].type + " is not alive.");
                        SelectDinosaurToAttack();
                    }
                    else
                    { 
                        Console.WriteLine(herd.Dinos[0].type + " has been selected!");
                        dinosaurNumber = 0;
                    }
                    break;
                case 2:
                    if (!herd.Dinos[1].isAlive)
                    {
                        Console.WriteLine(herd.Dinos[1].type + " is not alive.");
                        SelectDinosaurToAttack();
                    }
                    else
                    {
                        Console.WriteLine(herd.Dinos[1].type + " has been selected!");
                        dinosaurNumber = 1;
                    }
                    break;
                case 3:
                    
                    if (!herd.Dinos[2].isAlive)
                    {
                        Console.WriteLine(herd.Dinos[2].type + " is not alive.");
                        SelectDinosaurToAttack();
                    }
                    else
                    {
                        Console.WriteLine(herd.Dinos[2].type + " has been selected!");
                        dinosaurNumber = 2;
                    }
                    break;
                default:
                    Console.WriteLine("Your selection was outside of 1-3, select again.");
                    SelectDinosaurToAttack();
                    break;
                    
            }
            return dinosaurNumber;
        }
        public int SelectRobotThatAttacks()
        {
            int robotNumber = 0;

            Console.WriteLine("Select robot to complete attack:");
            Console.WriteLine("1) Assaultron: Status " + IsRobotSelectedAlive(0));
            Console.WriteLine("2) Liberty-Prime: Status " + IsRobotSelectedAlive(1));
            Console.WriteLine("3) Sentry-Bot: Status " + IsRobotSelectedAlive(2));
            int UserSelection = int.Parse(Console.ReadLine());

            switch (UserSelection)
            {
                case 1:
                    if (!fleet.Robots[0].isInWorkingOrder)
                    {
                        Console.WriteLine(fleet.Robots[0].name + " is not alive.");
                        SelectRobotThatAttacks();
                    }
                    else
                    {
                        Console.WriteLine(fleet.Robots[0].name + " has been selected!");
                        robotNumber = 0;
                    }
                    break;
                case 2:
                    if (!fleet.Robots[1].isInWorkingOrder)
                    {
                        Console.WriteLine(fleet.Robots[1].name + " is not alive.");
                        SelectRobotThatAttacks();
                    }
                    else
                    {
                        Console.WriteLine(fleet.Robots[1].name + " has been selected!");
                        robotNumber = 1;
                    }
                    break;
                case 3:
                    if (!fleet.Robots[2].isInWorkingOrder)
                    {
                        Console.WriteLine(fleet.Robots[2].name + " is not alive.");
                        SelectRobotThatAttacks();
                    }
                    else
                    {
                        Console.WriteLine(fleet.Robots[2].name + " has been selected!");
                        robotNumber = 2;
                    }
                    break;
                default:
                    Console.WriteLine("Your selection was outside of 1-3, select again.");
                    SelectRobotThatAttacks();
                    break;

            }
            return robotNumber;
        }
        public void RobotAttackRound()
        {

            //Robot attacks with choices
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
                Weapon sword = new Weapon("sword", 10);
                Weapon bat = new Weapon("bat", 5);
                Weapon glock = new Weapon("glock", 20);

                Console.WriteLine("You will now select the weapon for robot " + fleet.Robots[i].name + ":");
                Console.WriteLine("1) Sword\n2) Bat\n3) Glock");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("A sword?\nTrusty and reliable!\n");
                        Console.WriteLine("Click any key to continue");
                        Console.ReadLine();
                        fleet.Robots[i].weapon = sword;
                        break;
                    case 2:
                        Console.WriteLine("A bat?\nHow did you even get that here?\n");
                        Console.WriteLine("Click any key to continue");
                        Console.ReadLine();
                        fleet.Robots[i].weapon = bat;
                        break;
                    case 3:
                        Console.WriteLine("Ah yes...the mighty glock!\n");
                        Console.WriteLine("Click any key to continue");
                        Console.ReadLine();
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
