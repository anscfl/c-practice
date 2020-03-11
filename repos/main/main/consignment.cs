using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Consignment : Grocery
    {
        protected int amount;
        public Consignment(string name, int price, DateTime date, DateTime expdate, int amount) : base(name, price, date, expdate)
        {
            this.amount = amount;
        }
    }
}
