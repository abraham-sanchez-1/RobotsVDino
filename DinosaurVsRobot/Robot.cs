using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurVsRobot
{
    class Robot
    {
        //member variables
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;
        public bool isInWorkingOrder;

        //Constructor
        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
            isInWorkingOrder = true;
        }
        //member method
        public void Attack(Dinosaur dinosaur)
        {
            Console.WriteLine("Robot " + name + " will attack for " + (powerLevel + weapon.attackPower) + " total points!");
            dinosaur.health -= ((powerLevel) + (weapon.attackPower));
            Console.WriteLine(dinosaur.type + " is now at " + dinosaur.health + " health points!");
            if(dinosaur.health <= 0)
            {
                dinosaur.isAlive = false;
                Console.WriteLine(dinosaur.type + " has been KNOCKED OUT!!!");
            }
        }
        public void ReportBotStats()
        {
            if(isInWorkingOrder)
            {
                Console.WriteLine(name + " is alive!\nCurrent health is at: " + health);
            }

        }

    }
}
