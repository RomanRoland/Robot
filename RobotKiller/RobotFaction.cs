﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotKiller
{
    internal class RobotFaction
    {
        public bool Active { get; set; }
        public sbyte Health { get; set; }
        public sbyte Resistence { get; set; }
        public sbyte Attack { get; set; }

        public string[] Target { get; set; }
    }
}