﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurVsRobot
{
    class Herd
    {
        //member variable
        public List<Dinosaur> Dinos;

        //constructor
        public Herd()
        {
            Dinos = new List<Dinosaur>();
            CreateHerd();
            
        }
        //member method
        public void CreateHerd()
        {
            Dinos.Add(new Dinosaur("T-Rex", 200, 50, 75));
            Dinos.Add(new Dinosaur("Velociraptor", 60, 100, 15));
            Dinos.Add(new Dinosaur("Triceratops", 100, 65, 40));
        }
        public bool HerdAlive()
        {
            int dinosaursAlive = 3;
            for (int i = 0; i < Dinos.Count; i++)
            {
                if (!Dinos[i].isAlive)
                {
                    dinosaursAlive--;
                }
            }
            if (dinosaursAlive > 0)
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
