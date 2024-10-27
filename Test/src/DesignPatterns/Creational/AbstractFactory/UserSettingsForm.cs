using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Creational.AbstractFactory.UIMac;
using Test.src.DesignPatterns.Creational.AbstractFactory.UIWindows;

namespace Test.src.DesignPatterns.Creational.AbstractFactory
{
    public class UserSettingsForm
    {
        public void Render(IUIComponentFactory uIComponentFactory){
            // if(os == OperatingSystemType.Windows){
            //     new WindowsButton().Render();
            //     new WindowsCheckbox().Render();
            // } else if(os == OperatingSystemType.Mac){
            //     new MacButton().Render();
            //     new MacCheckbox().Render();
            // }

            uIComponentFactory.CreateButton().Render();
            uIComponentFactory.CreateCheckbox().Render();
        }
    }
}