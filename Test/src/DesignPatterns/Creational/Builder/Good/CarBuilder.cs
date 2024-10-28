using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Creational.Builder.Components;

namespace Test.src.DesignPatterns.Creational.Buider.Good
{
    public class CarBuilder : IBuilder
    {
        private Car _car;
        public CarBuilder(){
            Reset();
        }

        public void Reset()
        {
            _car = new Car();
        }

        public IBuilder IsConvertible(bool isConvertible)
        {
            throw new NotImplementedException();
        }

        public IBuilder SetCarType(CarType type)
        {
            _car._type = type;
            return this;
        }

        public IBuilder SetDashboard(Dashboard dashboard)
        {
            _car._dashboard = dashboard;
            return this;
        }

        public IBuilder SetEngine(Engine engine)
        {
            _car._engine = engine;
            return this;
        }

        public IBuilder SetGPSNavigator(GPSNavigator gPSNavigator)
        {
            _car._navigator = gPSNavigator;
            return this;
        }

        public IBuilder SetWheels(Wheels wheels)
        {
            _car._wheels = wheels;
            return this;
        }

        public Car GetCar(){
            var car = _car;
            Reset();
            return car;
        }

        public IBuilder SetSeats(int seats)
        {
            _car._seats = seats;
            return this;
        }
    }
}