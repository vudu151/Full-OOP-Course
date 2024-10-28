using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Creational.Buider.Good;
using Test.src.DesignPatterns.Creational.Builder.Components;

namespace Test.src.DesignPatterns.Creational.Builder.Good
{
    public class CarManualBuilder : IBuilder
    {
        public Manual _manual;
        public CarManualBuilder(){
            Reset();
        }

        public IBuilder IsConvertible(bool isConvertible)
        {
            _manual._isConvertible = isConvertible;
            return this; 
        }

        public void Reset()
        {
            _manual = new Manual();
        }

        public IBuilder SetCarType(CarType type)
        {
            _manual._type = type;
            return this;
        }

        public IBuilder SetDashboard(Dashboard dashboard)
        {
            _manual._dashboard = dashboard;
            return this;
        }

        public IBuilder SetEngine(Engine engine)
        {
            _manual._engine = engine;
            return this;
        }

        public IBuilder SetGPSNavigator(GPSNavigator gPSNavigator)
        {
            _manual._gpsNavigator = gPSNavigator;
            return this;
        }

        public IBuilder SetWheels(Wheels wheels)
        {
            _manual._wheels = wheels;
            return this;
        }

        public Manual GetManual(){
            var manual = _manual;
            Reset();
            return manual;
        }

        public IBuilder SetSeats(int seats)
        {
            _manual._seats = seats;
            return this;
        }
    }
}