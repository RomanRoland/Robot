using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotKiller
{
    public static class Engine
    {
        public static void Generate()
        {
            Random rnd = new Random();
            Planets[] planets = new Planets[4];
            for (int i = 0; i < 2; i++) 
                planets[i] = new Earth();
            for (int i = 2; i < 4; i++)
                planets[i] = new RobotBase();

        }
    }
}
