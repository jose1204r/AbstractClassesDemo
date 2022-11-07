using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal  class Motorcycle : Vehicle
    {

       
        public override void Drivevirtual()
        {
            Console.WriteLine($"This {GetType().Name} is{GetType().BaseType.Name} that is virtually driving");
        }

        public override void DriveAbtract()
        {
            Console.WriteLine("This Motrocycle drive !");
        }


        public bool HasSideCart { get; set; } = false; 
        

    }
}
