using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int numbersofvehicles;

        public string Make { get; set; } = "Default Make";

        public string Model { get; set; } = "Default Mode";


        public int Year { get; set; } = 1;

        public abstract void DriveAbtract();

        public virtual void Drivevirtual() 
        {

            Console.WriteLine($"This {GetType().Name} is virtually driving");
        
        }




       


    }
}
