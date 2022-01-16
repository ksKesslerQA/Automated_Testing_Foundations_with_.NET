using System;

namespace Interfaces_and_abstract_classes
{
    public class Airplane : IFlyable
    {
        public Coords CurrentCoords;

        public int speed = 200;
        //airplane increases speed by 10 km/h every 10 km of flight from an initial speed of 200 km/h
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

            for (double i = distance; i > 0; i -= 10)
            {
                //Console.WriteLine(i);

                if ( i > 10)
                {
                    flyTime += (10 / speed) * 60;
                    speed += 10;
                }
                    flyTime += (i / speed) * 60;
                    speed += 10;
            }

            Console.WriteLine("Fly time is " + flyTime + " m");
            return flyTime;
        }
    }
}
