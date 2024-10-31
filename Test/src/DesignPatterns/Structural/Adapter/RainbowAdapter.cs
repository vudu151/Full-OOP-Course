using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Structural.Adapter.Package;

namespace Test.src.DesignPatterns.Structural.Adapter
{
    public class RainbowAdapter : Rainbow, Color
    {
        public void Apply(Video video)
        {
            Setup();
            Update(video); 
        }
    }
}