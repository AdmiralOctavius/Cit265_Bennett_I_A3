using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit265_Bennett_I_A3
{
    public class Boat : Vessel
    {
        public int oars;

        public int getOars()
        {
            return oars;
        }

        public Boat(string inname = "Something", int inspeed = 4, int inoars = 2)
        {
            name = inname;
            speed = inspeed;
            oars = inoars;
        }
        public override void Move()
        {
            Console.WriteLine($"{name} is moving at a speed of: {speed * oars}.");
        }
    }

}
