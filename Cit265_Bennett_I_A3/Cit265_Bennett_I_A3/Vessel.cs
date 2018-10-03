using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT263_Bennett_I_A3
{
    //Interface is a lightweight structure that is a simple datatype/method holder
    interface IRefillable
    {
        void Refill(int amt);

        float FuelPercentage();
    }

    

    public class Vessel
    {
        public string name;
        public float speed;

        public virtual void Move()
        {
            Console.WriteLine($"Moving at {speed}.");
        }
    }

    public class Ship : Vessel, IRefillable
    {
        public int fuel;
        public int maxFuel;
        
        public override void Move()
        {
            if(fuel > 0)
            {
                Console.WriteLine($"Moving at {speed}.");
                Console.WriteLine("Removing 1 fuel");
            }
        }

        public void Refill(int amt)
        {
            fuel += amt;
            if(fuel > maxFuel)
            {
                fuel = maxFuel;
            }
        }

        public float FuelPercentage()
        {
            return fuel / maxFuel;
        }
    }

    public class Boat : Vessel
    {
        public int oars;

        public override void Move()
        {
            Console.WriteLine($"Moving at {speed * oars}.");
        }
    }

    public class Cat : IRefillable
    {
        public int hunger;
        public int maxHunger;
        //Review his in book, pages-342-353
        
        public float FuelPercentage()
        {
                return hunger / maxHunger;
        }

        public void Refill(int amt)
        {
            hunger = hunger - amt;
            if(hunger < 0)
            {
                hunger = 0;
            }
        }
    }


    

}
