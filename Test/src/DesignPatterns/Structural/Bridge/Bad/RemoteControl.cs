using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Bridge.Bad
{
    public abstract class RemoteControl
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void VolumneUp();
        public abstract void VolumneDown();
    }
}