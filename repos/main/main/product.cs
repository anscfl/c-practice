using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract public class Product
    {
        abstract public void ShowInfo();
        abstract public void ShowExpired();
        protected string name;
        protected DateTime date, expdate;
        protected int price;
    }
}
