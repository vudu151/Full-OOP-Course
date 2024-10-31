using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Bridge.Bad
{
    public class LGRemote : RemoteControl
    {
        public override void TurnOff()
        {
            System.Console.WriteLine("Turning LG radio off");
        }

        public override void TurnOn()
        {
            System.Console.WriteLine("Turning LG radio on");
        }

        public override void VolumneDown()
        {
            System.Console.WriteLine("Turning LG radio volume down");
        }

        public override void VolumneUp()
        {
            System.Console.WriteLine("Turning LG radio volume up");
        }
    }
}