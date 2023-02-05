using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;
        //or you can leave out false since it has default value of false
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving..");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive);
        }
    }
    }
}
