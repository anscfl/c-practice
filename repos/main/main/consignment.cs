using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    public class Consignment : Grocery
    {
        protected int amount;
        public Consignment(string name, int price, string date, DateTime expdate, int amount) : base(name, price, date, expdate)
        {
            this.amount = amount;
        }
    }
}
