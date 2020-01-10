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
            Console.WriteLine("Robot " + name + " will attack " + dinosaur.type );
            int finalAttack;
            int randomNumber;
            //instantiate random
            Random random = new Random();
            randomNumber = random.Next(0, 3);
            if (randomNumber != 0)
            {
                finalAttack = (weapon.attackPower + powerLevel) * randomNumber;

                dinosaur.health -= finalAttack;
                Console.WriteLine("The attack was effective!\nDamage output was " + finalAttack);
                Console.WriteLine(dinosaur.type + " is now at " + dinosaur.health + " health points!");
                if (dinosaur.health <= 0)
                {
                    dinosaur.isAlive = false;
                    Console.WriteLine(dinosaur.type + " has been KNOCKED OUT!!!");
                }
            }
            else
            {
               Console.WriteLine(name + " missed!");
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
