using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Bridge.Good
{
    public class LGRadio : Device
    {
        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Turning LG" + channel);
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Turning LG radio off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turning LG radio on");
        }
    }
}