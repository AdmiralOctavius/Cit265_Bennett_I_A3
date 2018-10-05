using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit265_Bennett_I_A3
{
<<<<<<< HEAD
=======
    //Interface is a lightweight structure that is a simple datatype/method holder
    interface IRefillable
    {
        void Refill(int amt);

        float FuelPercentage();
    }

    
>>>>>>> origin/master

    public class Vessel
    {
        public string name;
        public float speed;

        public Vessel(float speed = 1, string name = "The Grand Ole Slowy")
        {
            this.speed = speed;
            this.name = name;
        }
<<<<<<< HEAD

        public string getName()
=======
    }

    public class Ship : Vessel, IRefillable
    {
        public int fuel;
        public int maxFuel;
        
        public override void Move()
>>>>>>> origin/master
        {
            return name;
        }
<<<<<<< HEAD
        public float getSpeed()
=======

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
>>>>>>> origin/master
        {
            return speed;
        }
<<<<<<< HEAD

        public virtual void Move()
        {
            Console.WriteLine($"{name} is moving at a speed of: {speed}.");
        }
    }

}
=======
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
>>>>>>> origin/master
