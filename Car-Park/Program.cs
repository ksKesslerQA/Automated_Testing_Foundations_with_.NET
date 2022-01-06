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
            Car PassengerCar = new Car("Passenger car");

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

            Car Truck = new Car("Truck");

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

            Car Bus = new Car("Bus");

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

            Car Scooter = new Car("Scooter");

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


    }
    }
}
