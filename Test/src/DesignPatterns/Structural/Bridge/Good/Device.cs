using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Bridge.Good
{
    public interface Device
    {
        public void TurnOn();
        public void TurnOff();
        public void SetChannel(int channel);
    }
}