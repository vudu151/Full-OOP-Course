using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Bridge.Bad
{
    public abstract class RadioAndTVRemote : RemoteControl
    {
        public abstract void ControlTV();
        public abstract void ControlRadio();
    }
}