/*
 Name: Isaac Bennett
 Class: Cit265
 Assignment: 3
 Professor: Dr. Mauro
 ----
 Notes: Help recieved- massive thanks to Kristofer Constantino, 
    helping me later on with such basic stuff as "Why can I not see a file"
 
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit265_Bennett_I_A3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vessel> dockManifest = new List<Vessel>();
            dockManifest.Add(new Vessel(2, "Tuggy"));
            dockManifest.Add(new Boat("The Little boat", 5, 4));
            dockManifest.Add(new Ship(5, 15, "The Ship that could", 4));
            dockManifest.Add(new Vessel(5));
            dockManifest.Add(new Vessel(5, "The Starship Enterprise"));
            dockManifest.Add(new Boat("DoomBoat", 5, 0));
            dockManifest.Add(new Ship(0, 15, "The Ship that couldn't", 4));
            dockManifest.Add(new Vessel(100, "SuperSonic Santa"));

            foreach (Vessel curVessel in dockManifest)
            {
                curVessel.Move();
            }

            Console.WriteLine("\n");

            Cat myCat = new Cat(10, "Fluffy", 4);
            Console.WriteLine("Cat hunger % is: " + myCat.FuelPercentage + "%");
            Console.WriteLine("Refilling Cat belly...");
            myCat.Refill(3);
            Console.WriteLine("Cat hunger % is: " + myCat.FuelPercentage + "%");

            Ship Titanic = new Ship(30, 100, "Titanic 2", 1);
            Console.WriteLine("Ship fuel % is: " + Titanic.FuelPercentage + "%");
            Console.WriteLine("Refilling Ship tank...");
            Titanic.Refill(100);
            Console.WriteLine("Ship fuel % is: " + Titanic.FuelPercentage + "%");

        }
    }
}
