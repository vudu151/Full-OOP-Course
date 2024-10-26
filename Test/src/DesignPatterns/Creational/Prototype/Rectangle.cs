using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Creational.Prototype
{
    public class Rectangle : Shape
    {
        public int Width {get; set; } = 10;
        public int Height {get; set; } = 5;
        public void Draw()
        {
            System.Console.WriteLine("Drawing Rectangle");
        }

        public Shape Duplicate(){
            var newRectangle = new Rectangle();
            newRectangle.Width = Width;
            newRectangle.Height = Height;
            return newRectangle;
        }
    }
}