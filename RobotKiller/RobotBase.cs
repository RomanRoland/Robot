using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotKiller
{
    internal class RobotBase : Planets
    {
        public GiantRobotKiller[] GiantRobotKiller { get; set; }
        public RobotShip[] RobotShip { get; set; }
        public RobotTroopers[] Troopers { get; set; }
        public RobotBase()
        {
            Random rnd = new Random();
            Materials = (short)rnd.Next(1000, 3500);
            Factories = (short)rnd.Next(5, 20);
            Troopers = new RobotTroopers[rnd.Next(10 , 100)];
            RobotShip = new RobotShip[2];
        }
    }
}
