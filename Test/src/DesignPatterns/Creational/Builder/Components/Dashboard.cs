using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Creational.Builder.Components
{
    public class Dashboard
    {
        private bool _hasRevCounter = false;
        public Dashboard(bool hasRevCounter){
            _hasRevCounter = hasRevCounter;
        }
    }
}