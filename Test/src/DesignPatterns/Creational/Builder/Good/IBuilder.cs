using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Creational.Builder.Components;

namespace Test.src.DesignPatterns.Creational.Buider.Good
{
    public interface IBuilder
    {
        void Reset();
        IBuilder SetCarType(CarType type);
        IBuilder SetSeats(int seats);
        IBuilder IsConvertible(bool isConvertible);
        IBuilder SetEngine(Engine engine);
        IBuilder SetWheels(Wheels wheels);
        IBuilder SetDashboard(Dashboard dashboard);
        IBuilder SetGPSNavigator(GPSNavigator gPSNavigator);
    }
}