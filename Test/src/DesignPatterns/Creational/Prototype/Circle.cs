using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Creational.Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; } = 5;
        public void Draw()
        {
            System.Console.WriteLine("Drawing Circle");
        }

        public Shape Duplicate()
        {
            var newCircle = new Circle();
            newCircle.Radius = Radius;
            return newCircle;
        }
    }
}