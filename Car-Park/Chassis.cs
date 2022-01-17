namespace Car_Park
{
    public class Chassis
    {
        public string name;
        public Chassis(string Name)
        {
            name = Name;
        }

        public int numberOfWheels;
        public string licensePlate = "unknown";
        public int permissibleLoad;
    }
}
