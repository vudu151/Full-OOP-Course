using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Creational.AbstractFactory.UIMac
{
    public class MacCheckbox : ICheckbox
    {
        public void Render(){
            System.Console.WriteLine("Mac: render checkbox");
        }
    }
}