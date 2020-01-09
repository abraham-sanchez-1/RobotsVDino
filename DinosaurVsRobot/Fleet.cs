using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurVsRobot
{
    class Fleet
    {
        List<Robot> Robots;
        Weapon sword = new Weapon("melee", 10);
        Weapon bat = new Weapon("melee", 5);
        Weapon glock = new Weapon("range", 20);

        //constructor
        public Fleet()
        {
            Robots = new List<Robot>();
            CreateFleet();

        }
        //member method
        public void CreateFleet()
        {
            Robots.Add(new Robot("Bobby", 50, 30, sword));
            Robots.Add(new Robot("Billy-Bob", 50, 30, bat));
            Robots.Add(new Robot("Bobbert", 50, 30, glock));
        }
    }
}
