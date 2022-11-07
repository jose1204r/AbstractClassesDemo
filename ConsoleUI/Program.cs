using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            // Vehicles  List
            // 
            

            var ListofVehicle = new List<Vehicle>();
            

            // 4 vehicles created
            var lexus = new Car { Make = "lexus", Year = 2021, Model = "LD", Hastruck = true };
            var harleydavidson = new Motorcycle { Make = "Davidson" , Year = 2022, Model ="GA", HasSideCart = true };
            Vehicle ferarri = new Car { Model = "Spider", Make = "Ferrari", Year = 2022, Hastruck = true };
            Vehicle ford = new Car { Model = "focus", Make = "Ford", Year = 2015, Hastruck = true };
            
            // 4 vehicles added to the list 
            ListofVehicle.Add(lexus);
            ListofVehicle.Add(harleydavidson);
            ListofVehicle.Add(ford);
            ListofVehicle.Add(ferarri);


            Console.WriteLine("MAKE MODEL YEAR");
            foreach (var vh in ListofVehicle) 
            {
                
                Console.WriteLine($"{vh.Make} {vh.Model} {vh.Year}");
            }

            // Mothods called
            
            lexus.DriveAbtract();
            lexus.Drivevirtual();
            harleydavidson.DriveAbtract();
            harleydavidson.Drivevirtual();
            
            #region Vehicles

            /*
             * done.Create an abstract class called Vehicle
             * done The vehicle class shall have three string properties Year, Make, and Model
             * done Set the defaults to something generic in the Vehicle class
             * done Vehicle shall have an abstract method called DriveAbstract with no implementation
             * done Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             *done Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             *done Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             *done Provide the implementations for the abstract methods
             *done Only in the Motorcycle class will you override the virtual drive method
            */

            //done Create a list of Vehicle called vehicles

            /*
             *done Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             *done - new it up as one of each derived class
             *done Set the properties with object initializer syntax
             */

            /*
             * doneAdd the 4 vehicles to the list
             * done Using a foreach loop iterate over each of the properties
             */

            // done  Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
