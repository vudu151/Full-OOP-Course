using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Creational.Singleton
{
    public class TestSingleton
    {
        public static void Run(){
            var settings = new AppSettings();
            System.Console.WriteLine(settings.Get("app_name"));
        }
    }
}