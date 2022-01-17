using System;
using System.Reflection;

namespace Car_Park
{
    public class Vehicle
    {
        public string Name { get; }

        public string EngineName { get; }
        public int EnginePower { get; }
        public double EngineVolume { get; }
        public string EngineType { get; }
        public string EngineSerialNumber { get; }

        public string TransmissionName { get; }
        public string TransmissionType { get; }
        public int TransmissionNumberOfGears { get; }
        public string TransmissionManufacturer { get; }

        public string ChassisName { get; }
        public int ChassisNumberOfWheels { get; }
        public string ChassisLicensePlate { get; }
        public int ChassisPermissibleLoad { get; }

        public Vehicle(string name, Engine engine, Transmission transmission, Chassis chassis)
        {
            Name = name;

            EngineName = engine.name;
            EnginePower = engine.power;
            EngineVolume = engine.volume;
            EngineType = engine.type;
            EngineSerialNumber = engine.serialNumber;

            TransmissionName = transmission.name;
            TransmissionType = transmission.type;
            TransmissionNumberOfGears = transmission.numberOfGears;
            TransmissionManufacturer = transmission.manufacturer;

            ChassisName = chassis.name;
            ChassisNumberOfWheels = chassis.numberOfWheels;
            ChassisLicensePlate = chassis.licensePlate;
            ChassisPermissibleLoad = chassis.permissibleLoad;
        }


        public static void GetFullInfo(Object obj)
        {
            Type t = obj.GetType();
            Console.WriteLine("Type is: {0}", t.Name);
            PropertyInfo[] props = t.GetProperties();

            foreach (var prop in props)
            {
                Console.WriteLine("   {0} : {1}", prop.Name, prop.GetValue(obj));
            }
        } 
        
    }
}
