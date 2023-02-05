using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    { 
        public string Year { get; set; } = "generic";
        public string Make { get; set; } = "generic";
        public string Model { get; set; } = "generic";

        public abstract void DriveAbstract(); //stubbed out method.

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} virtually in drive.");
        }

    }
}
