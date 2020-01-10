using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurVsRobot
{
    class Fleet
    {
        public List<Robot> Robots;
        Weapon sword = new Weapon("sword", 10);
        Weapon bat = new Weapon("bat", 5);
        Weapon glock = new Weapon("glock", 20);

        //constructor
        public Fleet()
        {
            Robots = new List<Robot>();
            CreateFleet();

        }
        //member method
        public void CreateFleet()
        {
            Robots.Add(new Robot("Assaultron", 200, 30, sword));
            Robots.Add(new Robot("Liberty-Prime", 50, 30, bat));
            Robots.Add(new Robot("Sentry-bot", 50, 30, glock));
        }
        public bool FleetAlive()
        {
            int robotsAlive = 3;
            for (int i = 0; i < Robots.Count; i++)
            {
                if (!Robots[i].isInWorkingOrder)
                {
                    robotsAlive--;
                }
            }
            if (robotsAlive > 0)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
        
    }
}
