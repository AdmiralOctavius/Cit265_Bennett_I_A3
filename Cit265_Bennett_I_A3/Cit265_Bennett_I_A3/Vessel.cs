using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit265_Bennett_I_A3
{

    public class Vessel
    {
        public string name;
        public float speed;

        public Vessel(float speed = 1, string name = "The Grand Ole Slowy")
        {
            this.speed = speed;
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
        public float getSpeed()
        {
            return speed;
        }

        public virtual void Move()
        {
            Console.WriteLine($"{name} is moving at a speed of: {speed}.");
        }
    }

}