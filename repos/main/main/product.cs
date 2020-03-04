using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    abstract public class Product
    {
        abstract public void ShowInfo();
        abstract public void ShowExpired();
        protected string name, date;
        protected DateTime expdate;
        protected float price;
    }
}
