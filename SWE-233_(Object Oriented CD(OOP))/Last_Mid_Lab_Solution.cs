using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class order
    {
        string id;
        double price;
        public void calcTax()
        {
            price += price * 5 / 100;
        }
        public void take_price(double p)
        {
            price = p;
        }
        class audience
        {
            string id;
            string name;
        }
        class user : audience
        {
            public void placeOrdera(order o)
            {
                Console.WriteLine("Press c to continue more order");
                string input = Console.ReadLine();
                if (input == "c")
                {
                    o.take_price(10000);
                }
                else
                    Console.WriteLine("Invalid Input");
            }
        }
        class manager : audience
        {
            public void calcDioscount(order o)
            {
                if (o.price > 5000)
                {
                    o.price -= o.price * 7 / 100;
                    Console.WriteLine("Total Price is " + o.price);
                }
                else
                    Console.WriteLine("Total price is " + o.price);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                order o = new order();
                o.take_price(7000);
                o.calcTax();
                manager m = new manager();
                m.calcDioscount(o);
                user u = new user();
                u.placeOrdera(o);
                o.calcTax();
                m.calcDioscount(o);
                Console.ReadLine();
            }
        }
    }

}
