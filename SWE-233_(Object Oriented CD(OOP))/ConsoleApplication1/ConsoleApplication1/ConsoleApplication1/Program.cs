using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Customer
    {
        private int _phone;
        private int _pin;
        private string _name;
        private int _id;
        private double _balance;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
        public void register(int phone, int pin, string name, int id, double balance)
        {
            _phone = phone;
            _pin = pin;
            _name = name;
            _id = id;
            _balance= balance;
            Console.WriteLine("Before Update Phone: " +_phone+ " Pin: " +_pin+ " Name:" + _name+ " Id:"+_id+ " Balance:"+_balance);
        }
        public void update(int phone, int pin, string name, double balance)
        {
            _phone = phone;
            _pin = pin;
            _name = name;
            _balance= balance;
            Console.WriteLine("After Update Phone: " + _phone + " Pin: " + _pin + " Name:" + _name + " Balance:" + _balance);
        }

        public void withdraw(int i)
        {
            _balance = _balance - i;
        }
        public void deposit(int i)
        {
            _balance = _balance + i;
        }
    }
    class Agent
    {
        private int _id;
        private string _name;
        public void register(int id, string name)
        {
            _id=id;
            _name= name;
        }
        public void registercustome(Customer c)
        {
            c.register(01716, 012, "Somebody", 1, 500);

        }
        public void updatecustomer(Customer c)
        {
            c.update(01716, 012, "Ihsan ahmed", 1000);

        }
        public void print(Customer cus)
        {
            Console.WriteLine("Customer name: " +cus.name+ "   Current balance: " + cus.balance);
        }

    }
    class Manager
    {
        private int _id;
        private string _name;
        public Manager(int id, string name)
        {
            _id=id;
            _name= name;
        }
        public void registeragent(Agent ag)
        {
            ag.register(1,"Habib");
        }

    }
    class Mobilebanking
    {
        static void Main(string[] args)
        {
            Agent ag = new Agent();
            Manager man= new Manager(1, "Moon");
            man.registeragent(ag);
            Customer cus = new Customer();
            ag.registercustome(cus);
            ag.updatecustomer(cus);
            cus.withdraw(100);
            cus.deposit(500);
            ag.print(cus);
            Console.ReadLine();
            
        }
    }
}
