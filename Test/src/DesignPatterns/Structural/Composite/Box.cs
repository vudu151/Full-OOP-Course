using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Composite
{
    public class Box : Item
    {
        private List<Item> _items = new List<Item>();
        public void Add(Item item){
            _items.Add(item);
        }
        public int GetPrice()
        {
            int total = 0;
            foreach (var item in _items){
                total += item.GetPrice();
            }
            return total;
        }
    }
}