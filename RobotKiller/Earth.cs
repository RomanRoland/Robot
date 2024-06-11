using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotKiller
{
    internal class Earth : Planets
    {
        public SuperHeroes[] SuperHeroes { get; set; }
        public Humans[] Humans { get; set; }
        public Animals[] Animals { get; set; }
        public Earth()
        {
            Random rnd = new Random();
            Materials = (short)rnd.Next(1000, 3500);
            Factories = (short)rnd.Next(5, 20);
            Humans = new Humans[rnd.Next(10, 50)];
            Animals = new Animals[rnd.Next(15, 200)];
            SuperHeroes = new SuperHeroes[1];
        }
    }
}
