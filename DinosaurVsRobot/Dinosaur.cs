using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurVsRobot
{
    class Dinosaur
    {
        //member variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        public bool isAlive;
        
        //Constructor
        public Dinosaur (string type, int health, int energy, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
            isAlive = true;
        }
        //member method
        public void Attack(Robot robotTarget)
        {
            Console.WriteLine("Dinosaur " + type + " will attack " + robotTarget.name);
            int finalAttack;
            int randomNumber;
            //instantiate random number
            Random random = new Random();
            randomNumber = random.Next(0, 3);
            if (randomNumber != 0)
            {
                finalAttack = randomNumber * attackPower;
                robotTarget.health -= finalAttack;
                Console.WriteLine("The attack was effective!\nDamage output was " + finalAttack);
                Console.WriteLine(robotTarget.name + " is now at " + robotTarget.health + " health points");
                if (robotTarget.health <= 0)
                {
                    robotTarget.isInWorkingOrder = false;
                    Console.WriteLine(robotTarget.name + " has been KNOCKED OUT!!!");
                }
            }
            else
            {
                Console.WriteLine(type + " missed!");
            }
        }
        public void ReportDinoStats()
        {
            if (isAlive)
            {
                Console.WriteLine(type + " is alive!\nCurrent health is: " + health);
            }
            
        }
    }
}
