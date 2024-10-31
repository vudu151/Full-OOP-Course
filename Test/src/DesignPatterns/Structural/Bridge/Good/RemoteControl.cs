using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Bridge.Good
{
    public class RemoteControl
    {
        private Device _device;
        public RemoteControl(Device device){
            _device = device;
        }

        public void TurnOn(){
            _device.TurnOn();
        }
        
        public void TurnOff(){
            _device.TurnOff();
        }
    }
}