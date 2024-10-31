using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Bridge.Bad
{
    public class LGRadioAndTVRemote : RadioAndTVRemote
    {
        public override void ControlRadio()
        {
            System.Console.WriteLine("Now controlling LG radio");
        }

        public override void ControlTV()
        {
            System.Console.WriteLine("Now controlling LG TV");
        }

        public override void TurnOff()
        {
            System.Console.WriteLine("Turning LG device off");
        }

        public override void TurnOn()
        {
            System.Console.WriteLine("Turning LG device off");
        }

        public override void VolumneDown()
        {
            System.Console.WriteLine("Turning LG volume down");
        }

        public override void VolumneUp()
        {
            System.Console.WriteLine("Turning LG volume up");
        }
    }
}