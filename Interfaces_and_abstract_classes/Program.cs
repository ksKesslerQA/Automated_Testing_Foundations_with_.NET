using System;

namespace Interfaces_and_abstract_classes
{
    // Практические задания
    // Создать структуру "Координата", определяющую 3D координаты некоторого объекта
    // (положительные числа). Определить интерфейс IFlyable с методами
    // FlyTo(новая точка), GetFlyTime(новая точка).
    // Создать классы "Птица", "Самолет", "Дрон", реализующие данный интерфейс
    // и содержащие как миминум поле "Текущее положение". 

    // Использовать следующие предположения: птица летит все расстояние с постоянной
    // скоростью в диапазоне 0-20 км/ч(заданной случайно), самолет увеличивает
    // скорость на 10 км/ч каждые 10 км полета от начальной скорости 200 км/ч.,
    // дрон зависает в воздухе каждые 10 минут полета на 1 минуту. Исходя из задачи,
    // ввести дополнительные ограничения(например, невозможность полета дрона
    // на дальность более чем на 1000 км).
    // Методы и введенные ограничения описать в комментариях.
    public struct Coords
    {
        public Coords(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public override string ToString() => $"({X}, {Y}, {Z})";

        public static double Distance(Coords p1, Coords p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X)
                             + (p1.Y - p2.Y) * (p1.Y - p2.Y)
                             + (p1.Z - p2.Z) * (p1.Z - p2.Z));
        }
    }

    interface IFlyable
    {
        void FlyTo(Coords newCoords);
        double GetFlyTime(Coords newCoords);
    }

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

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            var testBird = new Bird();
            testBird.CurrentCoords = new Coords(0, 0, 0);
            testBird.FlyTo(new Coords(15, 10, 10));
            Console.WriteLine(testBird.speed);
            testBird.GetFlyTime(new Coords(200, 100, 10));

            var testAirplane = new Airplane();
            testAirplane.CurrentCoords = new Coords(0, 0, 0);
            testAirplane.FlyTo(new Coords(10, 0, 0));
            Console.WriteLine(testAirplane.speed);
            testAirplane.GetFlyTime(new Coords(20, 160, 0));
            */

            var testDrone = new Drone();
            testDrone.CurrentCoords = new Coords(0, 0, 0);
            testDrone.speed = 10;
            testDrone.FlyTo(new Coords(10, 0, 0));
            Console.WriteLine(testDrone.speed);
            testDrone.GetFlyTime(new Coords(10, 10, 0));

        }
    }
}
