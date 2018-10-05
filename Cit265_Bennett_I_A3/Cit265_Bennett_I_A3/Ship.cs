using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit265_Bennett_I_A3
{
    public class Ship : Vessel, IRefillable
    {
        public int fuel;
        public int maxFuel;

        public int getFuel()
        {
            return fuel;
        }
        public int getMaxFuel()
        {
            return maxFuel;
        }

        public Ship(int infuel = 4, int inmaxFuel = 10, string inname = "Boaty Ship", int inSpeed = 3)
        {
            fuel = infuel;
            maxFuel = inmaxFuel;
            name = inname;
            speed = inSpeed;
        }

        public override void Move()
        {
            if (fuel > 0)
            {
                Console.WriteLine($"{name} is moving at a speed of: {speed}.");
                Console.WriteLine($"Removing 1 fuel from {name}");
                fuel--;
            }
            else
            {
                Console.WriteLine($"No fuel left in: {name}'s tank!");
            }
        }

        public void Refill(int amt)
        {
            fuel += amt;
            if (fuel > maxFuel)
            {
                fuel = maxFuel;
            }
        }

        public float FuelPercentage
        {
            get
            {
                return ((float)fuel / (float)maxFuel) * 100;
            }
        }
    }

}
