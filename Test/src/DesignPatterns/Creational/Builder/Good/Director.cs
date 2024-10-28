using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Creational.Buider.Good;
using Test.src.DesignPatterns.Creational.Builder.Components;

namespace Test.src.DesignPatterns.Creational.Builder.Good
{
    public class Director
    {
        public void ConstructorSportCar(IBuilder builder){
            builder.SetCarType(CarType.Sports)
                .SetSeats(2)
                .SetEngine(new Engine())
                .SetDashboard(new Dashboard(hasRevCounter: true))
                .SetWheels(new Wheels(diameterInInches: 20));
        }

        public void ConstructorSUV(IBuilder builder){
            builder.SetCarType(CarType.SUV)
                .SetSeats(5)
                .SetEngine(new Engine())
                .SetDashboard(new Dashboard(hasRevCounter: true))
                .SetWheels(new Wheels(diameterInInches: 19));
        }
    }
}