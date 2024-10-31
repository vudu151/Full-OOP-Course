using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Bridge.Bad
{
    public abstract class AdvancedRemote : RemoteControl
    {
        public abstract void SetChannel(int channel);
    }
}