using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Adapter
{
    public class BlackAndWhiteColor
    {
        public void Apply(Video video, Color color){
            System.Console.WriteLine("Applying black and white color to video");
        }
    }
}