using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotKiller
{
    internal class RobotShip : RobotFaction
    {
        public RobotShip()
        {
            Health = 30;
            Resistence = 3;
            Attack = 3;
        }
    }
}
