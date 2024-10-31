using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Structural.Adapter.Package;

namespace Test.src.DesignPatterns.Structural.Adapter
{
    public class RainbowColor : Color
    {
        private Rainbow _rainbow;
        public RainbowColor(Rainbow rainbow){
            _rainbow = rainbow;
        }

        public void Apply(Video video)
        {
            _rainbow.Setup();
            _rainbow.Update(video);
        }
    }
}