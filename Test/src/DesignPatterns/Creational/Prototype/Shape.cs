using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Creational.Prototype
{
    public interface Shape
    {
        void Draw();
        Shape Duplicate();
    }
}