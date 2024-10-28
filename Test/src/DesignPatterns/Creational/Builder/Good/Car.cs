using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Creational.Builder.Components;

namespace Test.src.DesignPatterns.Creational.Buider.Good
{
    public class Car
    {
        public CarType _type;
        public int _seats;
        public Engine _engine;
        public bool _isConvertible;
        public Dashboard _dashboard;
        public Wheels _wheels;
        public GPSNavigator _navigator;

        //Fields specific to this class:
        public double Fuel { get; set; }
        public Car(){}
        public Car(CarType type,
                int seats,
                bool isConvertible,
                Engine engine,
                Dashboard dashboard,
                Wheels wheels,
                GPSNavigator gPSNavigator 
        ){
             _type = type;
            _seats = seats;
            _isConvertible = isConvertible;
            _engine = engine;
            _dashboard = dashboard;
            _wheels = wheels;
            _navigator = gPSNavigator;
        }
    }
}