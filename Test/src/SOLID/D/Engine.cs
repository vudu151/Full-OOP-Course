using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.SOLID.D
{
    public class Engine : IEngine
    {
        public void Start(){
            System.Console.WriteLine("Engine started");
        }
    }
}