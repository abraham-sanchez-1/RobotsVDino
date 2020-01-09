using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurVsRobot
{
    class Weapon
    {
        public string type;
        public int attackPower;


        //constructor
        public Weapon (string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
        }
        //Weapon sword = new Weapon("melee", 10);
        //Weapon spear = new Weapon("range", 15);
        //Weapon glock = new Weapon("gun", 20);
    }
}
