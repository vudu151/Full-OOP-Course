using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Creational.AbstractFactory.UIMac;

namespace Test.src.DesignPatterns.Creational.AbstractFactory
{
    public class MacUIComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}