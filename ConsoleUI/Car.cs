using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {


       
        public override void DriveAbtract()
        {
            Console.WriteLine("This car is drive! ");
        }


        public override void Drivevirtual()
        {
            Console.WriteLine($"This {GetType().Name} that is virtually driving");
        }


        public bool Hastruck { get; set; } = true;
        
        
    
            


        
    }
            

    



}
