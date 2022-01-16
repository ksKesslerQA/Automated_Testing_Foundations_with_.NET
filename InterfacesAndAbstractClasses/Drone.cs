using System;

namespace Interfaces_and_abstract_classes
{
    public class Drone : IFlyable
    {
        public Coords CurrentCoords;

        public int speed;
        //drone hovering in the air every 10 minutes of flight for 1 minute
        public double flyTime;
        public double distance;


        public void FlyTo(Coords newCoords)
        {
            CurrentCoords = newCoords;
            Console.WriteLine("Flying to " + CurrentCoords.ToString());
        }


        public double GetFlyTime(Coords newCoords)
        {
            var distance = Coords.Distance(CurrentCoords, newCoords);
            flyTime = (distance / speed) * 60;

            int flyTimeCoef = (int) flyTime / 10;
            flyTime += flyTimeCoef;

            Console.WriteLine("Fly time is " + flyTime + " m");
            return flyTime;
        }
    }
}
