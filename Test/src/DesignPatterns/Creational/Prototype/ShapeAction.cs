using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Creational.Prototype
{
    public class ShapeAction
    {
        public Shape Duplicate(Shape shape){
            System.Console.WriteLine("Duplicate shape");
            return shape.Duplicate();
        }
    }
}