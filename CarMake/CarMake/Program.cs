using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMake
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Mitsubishi";
            car1.Model = "Evo IX";
            car1.Colour = "Black";
            car1.Rego = "XYZ987";

            Car car2 = new Car();
            car2.Make = "Honda";
            car2.Model = "n/a";
            car2.Colour = "Silver";
            car2.Rego = "HHH246";

            Console.WriteLine($"Car Details:\nMake: {car1.Make}\nModel: {car1.Model}\nColour: {car1.Colour}\nRego: {car1.Rego}");
            Console.WriteLine($"\nCar Details:\nMake: {car2.Make}\nModel: {car2.Model}\nColour: {car2.Colour}\nRego: {car2.Rego}");
            Console.ReadLine();
        }
    }

    class Car
    {
        /*Attributes*/
        private string make;
        private string model;
        private string colour;
        private string rego;

        /*Getters and Setters*/
        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Colour { get { return colour; } set { colour = value; } }
        public string Rego { get { return rego; } set { rego = value; } }
        
    }
}
