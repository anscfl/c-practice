using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ProductKit : Product
    {
        private Product[] amount;
        public ProductKit(string name, int price, Product[] amount, int n, DateTime expdate)
        {
            this.name = name;
            this.price = price;
            this.amount = new Product[n];
            this.expdate = expdate;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Название комплекта: {0}\n Цена: {1}\n Количество продуктов в комплекте: {2}\n", name, price, amount);
        }

        public override void ShowExpired()
        {
            if(DateTime.Today > expdate)
                Console.WriteLine("У {0} закончился срок годности.", name);
            else Console.WriteLine("У {0} не закончился срок годности.", name);
        }
    }
}
