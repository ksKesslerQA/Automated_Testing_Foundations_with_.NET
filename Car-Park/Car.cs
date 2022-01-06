using System;

namespace Car_Park
{
    public class Car
    {
        public string name;
        public Car(string Name)
        {
            name = Name;
        }

        public Engine Engine = new Engine();
        public Chassis Chassis = new Chassis();
        public Transmission Transmission = new Transmission();

        public void GetFullInformation()
        {
            Console.WriteLine("Full Information about the " + name + ": ");
            Console.WriteLine("Engine information: " + " Power: " + Engine.power + "; Volume: " + Engine.volume + "; Type: " + Engine.type + "; Serial Number: " + Engine.serialNumber + ";");
            Console.WriteLine("Chassis information: " + "Number of Wheels: " + Chassis.numberOfWheels + "; License Plate: " + Chassis.licensePlate + "; Permissible Load: " + Chassis.permissibleLoad + ";");
            Console.WriteLine("Transmission information: " + "Type: " + Transmission.type + "; Number of Gears: " + Transmission.numberOfGears + "; Manufacturer: " + Transmission.manufacturer + ";");
            Console.WriteLine();
        }
    }
}
