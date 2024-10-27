using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Creational.FactoryMethod_MVCFramework;

namespace Test.src.DesignPatterns.Creational.FactoryMethod.MVCFramework
{
    public class Controller
    {
        public void Render(string fileName, Dictionary<string, object> data){
            var viewEngine = CreateViewEngine();
            var html = viewEngine.Render(fileName, data);
            System.Console.WriteLine(html);
        }

        protected virtual ViewEngine CreateViewEngine(){
            return new BladeViewEngine();
        }
    }
}