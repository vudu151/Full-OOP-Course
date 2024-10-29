using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Composite
{
    public class Keyboard : Item
    {
        public int _price = 40;
        public int GetPrice()
        {
            return _price;
        }
    }
}