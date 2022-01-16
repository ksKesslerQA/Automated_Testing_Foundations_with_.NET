namespace Interfaces_and_abstract_classes
{
    interface IFlyable
    {
        void FlyTo(Coords newCoords);
        double GetFlyTime(Coords newCoords);
    }
}
