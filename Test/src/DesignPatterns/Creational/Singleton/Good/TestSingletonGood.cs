using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.DesignPatterns.Creational.Singleton.Good
{
    public class TestSingletonGood
    {
        public static void Run(){
            var settings = AppSettings.GetInstance();
            System.Console.WriteLine(settings.Get("app_name"));
        }
    }
}