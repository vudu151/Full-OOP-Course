using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Structural.Adapter.Package
{
    public class Rainbow
    {
        public void Setup(){
            System.Console.WriteLine("Setting up rainbow filter");
        }

        public void Update(Video video){
            System.Console.WriteLine("Applying rainbow filter to video");
        }
    }
}