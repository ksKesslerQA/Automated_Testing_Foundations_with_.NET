using System;

namespace Interfaces_and_abstract_classes
{
    public class Bird : IFlyable
    {
        public Coords CurrentCoords;
        static Random rnd = new Random();
        public int speed = rnd.Next(0, 20);
        //The bird flies the entire distance with a constant speed in the range of 0-20 km/h (given randomly)
        public double flyTime;


        public void FlyTo(Coords newCoords)
        {
            CurrentCoords = newCoords;
            Console.WriteLine("Flying to " + CurrentCoords.ToString());
        }


        public double GetFlyTime(Coords newCoords)
        {
            var distance = Coords.Distance(CurrentCoords, newCoords);
            flyTime = (distance / speed) * 60;
            Console.WriteLine("Fly time is " + flyTime + " m");
            return flyTime;
        }
    }
}
