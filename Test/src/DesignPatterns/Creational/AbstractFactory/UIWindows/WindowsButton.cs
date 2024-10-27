using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Creational.AbstractFactory.UIWindows
{
    public class WindowsButton : IButton
    {
        public void Render(){
            System.Console.WriteLine("Windows: render button");
        }
    }
}