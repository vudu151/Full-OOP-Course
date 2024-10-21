using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.OOPPrinciples.Polymorphism
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public virtual void Start(){
            System.Console.WriteLine("Vehicle is starting.");
        }
        public virtual void Stop(){
            System.Console.WriteLine("Vehicle is stopping.");
        }
    }
}