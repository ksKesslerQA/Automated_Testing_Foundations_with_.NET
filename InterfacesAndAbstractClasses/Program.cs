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
