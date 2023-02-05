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
           var vehicles = new List<Vehicle>();

            Car car1 = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = "2013" };
            
            Motorcycle motorcycle1 = new Motorcycle() 
            {
                HasSideCart = true,
                Year = "2001",
                Make = "Kawasaki",
                Model = "Ninja"
            };
            Vehicle vehicle1 = new Car() 
            {
                Make = "Tesla" ,
                Year = "2020",
                Model = "X"
            };
            Vehicle vehicle2 = new Motorcycle()
            {
                Make = "Suzuki",
                Year = "2010",
                Model = "GSXR"
            };

            vehicles.Add(car1); 
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1); 
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine("_________________  ");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();
                
            }
                

        }
    }
}
