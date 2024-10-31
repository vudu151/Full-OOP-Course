using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Bridge.Bad
{
    public class AdvancedLGRemote : AdvancedRemote
    {
        public override void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting LG channel " + channel);
        }

        public override void TurnOff()
        {
            System.Console.WriteLine("Turnning LG radio off");
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