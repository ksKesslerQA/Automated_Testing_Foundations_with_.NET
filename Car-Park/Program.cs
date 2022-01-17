using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace Car_Park
{
    // Для создания программы по управлению автопарком нужно реализовать следующие
    // сущности в виде отдельных классов: "Двигатель"(включает в себя поля мощность,
    // объем, тип, серийный номер), "Шасси"(количество колес, номер, допустимая
    // нагрузка), "Трансмиссия" (тип, количество передач, производитель). 

    // С использованием этих классов реализовать сущности "Легковой автомобиль",
    // "Грузовик", "Автобус", "Скутер" (отличающиеся уникальными полями),
    // и обеспечить вывод полной информации об объектах этих типов.

    class Program
    {

        static void Main(string[] args)
        {

            //Заполнить единую коллекцию, содержащую объекты типа "Грузовик", "Легковой автомобиль", "Автобус", "Скутер" (из предыдущего задания по ООП) с различными значениями полей.

            var theEngines = new List<Engine>
        {
            new Engine("Engine1") { power = 190, volume = 1.1, type = "some type", serialNumber = "12345a"},
            new Engine("Engine2") { power = 380, volume = 1.4, type = "V6", serialNumber = "62542kp"},
            new Engine("Engine3") { power = 190, volume = 1.8, type = "some type", serialNumber = "12345a"},
            new Engine("Engine4") { power = 190, volume = 2.9, type = "some type", serialNumber = "12345a"},
            new Engine("Engine5") { power = 190, volume = 3.5, type = "some type", serialNumber = "12345a"}
        };

            var theChassis = new List<Chassis>
        {
            new Chassis("Chassis1") { numberOfWheels = 4, permissibleLoad = 3500, licensePlate = "AB2022"},
            new Chassis("Chassis2") { numberOfWheels = 4, permissibleLoad = 3500, licensePlate = "AB2022"},
            new Chassis("Chassis3") { numberOfWheels = 4, permissibleLoad = 3500, licensePlate = "AB2022"},
            new Chassis("Chassis4") { numberOfWheels = 4, permissibleLoad = 3500, licensePlate = "AB2022"},
        };


            var theTransmissions = new List<Transmission>
        {
            new Transmission("Transmission1") { type = "Automatic", numberOfGears = 8, manufacturer = "Manufacturer1" },
            new Transmission("Transmission2") { type = "Semiautomatic", numberOfGears = 8, manufacturer = "Manufacturer1" },
            new Transmission("Transmission3") { type = "Manual", numberOfGears = 8, manufacturer = "Manufacturer1" },
            new Transmission("Transmission4") { type = "Automatic", numberOfGears = 8, manufacturer = "Manufacturer1" }
        };



            var vehicles = new List<Vehicle>
            {
                new PassengerCar("KIA 2021 Sportage", theEngines[0], theTransmissions[0], theChassis[0]),
                new PassengerCar("BMW X3", theEngines[1], theTransmissions[0], theChassis[2]),
                new Truck("2007 Volvo FM 8X4 LWB", theEngines[3], theTransmissions[1], theChassis[0]),
                new Truck("2021 Iveco Stralis X-Way", theEngines[3], theTransmissions[2], theChassis[2]),
                new Bus("2021 Zhongtong LCK6935H", theEngines[1], theTransmissions[0], theChassis[0]),
                new Bus("2018 MITSUBISHI ROSA", theEngines[0], theTransmissions[1], theChassis[2]),
                new Scooter("Suzuki Satria F150", theEngines[2], theTransmissions[1], theChassis[0]),
                new Scooter("Yamaha YP300R XMAX ABS", theEngines[3], theTransmissions[3], theChassis[3]),

            };

            /*
            foreach (var vehicle in vehicles)
            {
                Vehicle.GetFullInfo(vehicle);
            }
            
            
            var SelectedVehicles = from v in vehicles
                                   where v.EngineVolume > 1.5
                                   select v;
         */

            //Task 3 
            //Записать в соответствующие XML файлы следующую информацию:
            //Полную информацию о всех транспортных средствах, обьем двигателя которых больше чем 1.5 литров;

            var SelectedVehiclesToXML = new XElement ("Root",
                from v in vehicles
                where v.EngineVolume > 1.5
                select new XElement("Vehicle",
                           new XElement("Name", v.Name),
                           new XElement("EngineName", v.EngineName),
                           new XElement("EngineVolume", v.EngineVolume),
                           new XElement("EnginePower", v.EnginePower),
                           new XElement("EngineType", v.EngineType),
                           new XElement("EngineSerialNumber", v.EngineSerialNumber),
                           new XElement("ChassisName", v.ChassisName),
                           new XElement("ChassisNumberOfWheels", v.ChassisNumberOfWheels),
                           new XElement("ChassisPermissibleLoad", v.ChassisPermissibleLoad),
                           new XElement("ChassisPermissibleLoad", v.ChassisLicensePlate),
                           new XElement("TransmissionName", v.TransmissionName),
                           new XElement("TransmissionName", v.TransmissionType),
                           new XElement("TransmissionName", v.TransmissionNumberOfGears),
                           new XElement("TransmissionName", v.TransmissionManufacturer)
                        )
                    );

            SelectedVehiclesToXML.Save("SelectedVehicles.xml");


            //Task 4
            //Записать в соответствующие XML файлы следующую информацию:
            //Тип двигателя, серийный номер и его мощность для всех автобусов и грузовиков; 

            var SelectedBusAndTrackToXML = new XElement("Root",
                from v in vehicles
                where v.GetType().Name == "Bus" || v.GetType().Name == "Truck"
                select new XElement("Vehicle",
                           new XElement("Name", v.Name),
                           new XElement("EngineType", v.EngineType),
                           new XElement("EngineSerialNumber", v.EngineSerialNumber),
                           new XElement("EnginePower", v.EnginePower)
                        )
                    );

            SelectedBusAndTrackToXML.Save("SelectedBusAndTrack.xml");


            ////Task 5
            //Записать в соответствующие XML файлы следующую информацию:
            // Полную информацию о всех транспортных средствах, сгруппированную по типу трансмиссии.

            /*
            var GroupedVehicles = from v in vehicles
                                  group v by v.TransmissionType;

            foreach (IGrouping<string, Vehicle> g in GroupedVehicles)
            {
                Console.WriteLine(g.Key);
                foreach (var t in g)
                    Console.WriteLine(t.Name);
                Console.WriteLine();
            }
            */
            
    
            var AllVehiclesToXML = new XElement("Root",
                from v in vehicles
                group v by v.TransmissionType,
                select new XElement("Vehicle",
                           new XElement("Name", v.Name),
                           new XElement("EngineName", v.EngineName),
                           new XElement("EngineVolume", v.EngineVolume),
                           new XElement("EnginePower", v.EnginePower),
                           new XElement("EngineType", v.EngineType),
                           new XElement("EngineSerialNumber", v.EngineSerialNumber),
                           new XElement("ChassisName", v.ChassisName),
                           new XElement("ChassisNumberOfWheels", v.ChassisNumberOfWheels),
                           new XElement("ChassisPermissibleLoad", v.ChassisPermissibleLoad),
                           new XElement("ChassisPermissibleLoad", v.ChassisLicensePlate),
                           new XElement("TransmissionName", v.TransmissionName),
                           new XElement("TransmissionName", v.TransmissionType),
                           new XElement("TransmissionName", v.TransmissionNumberOfGears),
                           new XElement("TransmissionName", v.TransmissionManufacturer)
                        )
                    );



            AllVehiclesToXML.Save("AllVehiclesToXML.xml");

            /*
            PassengerCar PassengerCar = new PassengerCar("Passenger car");

            PassengerCar.Engine.power = 190;
            PassengerCar.Engine.volume = 2000;
            PassengerCar.Engine.type = "some type";
            PassengerCar.Engine.serialNumber = "12345a";

            PassengerCar.Chassis.numberOfWheels = 4;
            PassengerCar.Chassis.permissibleLoad = 3500;
            PassengerCar.Chassis.licensePlate = "AB2022";

            PassengerCar.Transmission.type = "Automatic";
            PassengerCar.Transmission.numberOfGears = 8;
            PassengerCar.Transmission.manufacturer = "Manufacturer1";

            PassengerCar.GetFullInformation();

            Truck Truck = new Truck("Truck");

            Truck.Engine.power = 380;
            Truck.Engine.volume = 11000;
            Truck.Engine.type = "V6";
            Truck.Engine.serialNumber = "62542kp";

            Truck.Chassis.numberOfWheels = 8;
            Truck.Chassis.permissibleLoad = 15000;
            Truck.Chassis.licensePlate = "HT2005";

            Truck.Transmission.type = "Manual";
            Truck.Transmission.numberOfGears = 5;
            Truck.Transmission.manufacturer = "Manufacturer3";

            Truck.GetFullInformation();

            Bus Bus = new Bus("Bus");

            Bus.Engine.power = 250;
            Bus.Engine.volume = 3000;
            Bus.Engine.type = "some type";
            Bus.Engine.serialNumber = "8475G";

            Bus.Chassis.numberOfWheels = 4;
            Bus.Chassis.permissibleLoad = 9000;
            Bus.Chassis.licensePlate = "WT0563";

            Bus.Transmission.type = "Automatic";
            Bus.Transmission.numberOfGears = 8;
            Bus.Transmission.manufacturer = "Manufacturer4";

            Bus.GetFullInformation();

            Scooter Scooter = new Scooter("Scooter");

            Scooter.Engine.power = 25;
            Scooter.Engine.volume = 170;
            Scooter.Engine.type = "type2";
            Scooter.Engine.serialNumber = "1234KMN";

            Scooter.Chassis.numberOfWheels = 2;
            Scooter.Chassis.permissibleLoad = 200;
            Scooter.Chassis.licensePlate = "CY1998";

            Scooter.Transmission.type = "Semiautomatic";
            Scooter.Transmission.numberOfGears = 4;
            Scooter.Transmission.manufacturer = "Manufacturer2";

            Scooter.GetFullInformation();
            */


        }
    }
}
