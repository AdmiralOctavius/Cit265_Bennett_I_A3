using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit265_Bennett_I_A3
{
    public class Cat : IRefillable
    {
        public int hunger;
        public int maxHunger;
        public string name;

        public int getHunger()
        {
            return hunger;
        }
        public void setHunger(int amt)
        {
            hunger += amt;
            if(hunger > maxHunger)
            {
                hunger = maxHunger;
            }
        }
        public int getMaxHunger()
        {
            return maxHunger;
        }
        public string getName()
        {
            return name;
        }

        public Cat(int InMaxHunger = 10, string inName = "Fluffles", int inHunger = 0)
        {
            maxHunger = InMaxHunger;
            hunger = inHunger;
            name = inName;
        }
        public void Refill(int amt)
        {
            hunger = hunger - amt;
            if (hunger < 0)
            {
                hunger = 0;
            }
        }

        public float FuelPercentage
        {
            get
            {
                return ((float)hunger / (float)maxHunger) * 100;
            }
        }


    }
}
