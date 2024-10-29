using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Composite
{
    public class Mouse : Item
    {
        public int _price = 43;
        public int GetPrice()
        {
            return _price;
        }
    }
}