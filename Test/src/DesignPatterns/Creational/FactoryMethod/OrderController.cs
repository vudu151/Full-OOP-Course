using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.src.DesignPatterns.Creational.FactoryMethod.MVCFramework;
using Test.src.DesignPatterns.Creational.FactoryMethod_MVCFramework;

namespace Test.src.DesignPatterns.Creational.FactoryMethod
{
    public class OrderController : TwigController
    {
        public void ListOrder(){
            //Simulate fetching users previous orders form db
            var orders = new Dictionary<string, object>{
                {"Red socks", "$10.12"},
                {"Green socks", "$32.12"},
                {"Yellow socks", "$33.11"}
            };

            Render("orders.blade.php", orders);
        }

        public void GetOrder(int id){
            //Simulate getting single order by id from db
            var order = new Dictionary<string, object>{
                {"Red Socks", "$12.11"}
            };
            Render("order.php", order);
        }
    }
}