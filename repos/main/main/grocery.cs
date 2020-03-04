using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    public class Grocery : Product
    {
        public Grocery(string name, int price, string date, DateTime expdate)
        {
            this.name = name;
            this.price = price;
            this.date = date;
            this.expdate = expdate;
        }

        public Grocery()
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Название: {0}\nЦена: {1}\n Дата производства: {2}\n Срок годности: {3}\n", name, price, date, expdate);
        }

        public override void ShowExpired()
        {
            if (DateTime.Today > expdate)
                Console.WriteLine("У {0} закончился срок годности.");
            else Console.WriteLine("У {0} не закончился срок годности.");
        }
    }
}
