using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Creational.Builder.Components;

namespace Test.src.DesignPatterns.Creational.Builder.Bad
{
    public class Manual
    {
        public CarType _type;
        public int _seats;
        public bool _isConvertible;
        public Engine _engine;
        public Dashboard _dashboard;
        public Wheels _wheels;
        public GPSNavigator _gpsNavigator;
        public Manual(CarType type,
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
            _gpsNavigator = gPSNavigator;
        }

         public string Print(){
            var text = "";
            text += "Car type: " + _type + "\n";
            text += "Seats" + _seats + "\n";
            text += "Wheels: diameter in inches = " + _wheels.GetDiameterInInches() + "\n";
            text += "GPS Navigator: ";
            if(_gpsNavigator != null){
                text += "Info on gps... \n";
            } else{
                text += "N/A \n";
            }
            return text;
         }
    }
}