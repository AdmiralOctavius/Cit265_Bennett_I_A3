using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT263_Bennett_I_A3
{
    public class Vessel
    {
        public string name;
        public float speed;

        public virtual void Move()
        {
            Console.WriteLine($"Moving at {speed}.");
        }
    }

    public class Ship : Vessel
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
    }

    public class Boat : Vessel
    {
        public int oars;

        public override void Move()
        {
            Console.WriteLine($"Moving at {speed * oars}.");
        }
    }
    //Interface is a lightweight structure that is a simple datatype/method holder
    interface IRefillable
    {
        void Refill(int amt);

        float FuelPercentage
        {
            get;
            set;
        }
    }

    public class Cat 
    {
        public int hunger;
        public int maxHunger;
        //Review his in book, pages-342-353
        
    }


    

}
