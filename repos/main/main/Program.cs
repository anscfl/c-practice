using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    static public Product[] Input()
    {
        using (StreamReader fileIn = new StreamReader(@"C:\Users\isaevayu\source\repos\ConsoleApp1\ConsoleApp1\input.txt")) {
            Console.Write("Введите количество товаров: ");
            int n = int.Parse(fileIn.ReadLine());
            Product[] inputArray = new Product[n];
            for(int i = 0; i < n; i++)
            {
                string[] text = fileIn.ReadLine().Split(' ');
                if (text.Length == 4)
                    inputArray[i] = new Grocery(text[0], int.Parse(text[1]), Convert.ToDateTime(text[2]), Convert.ToDateTime(text[3]));
                else if ((text.Length == 5) && (Char.IsDigit(text[0], 0)))
                    inputArray[i] = new Consignment(text[0], int.Parse(text[1]), Convert.ToDateTime(text[2]), Convert.ToDateTime(text[3]), int.Parse(text[4]))
                else
                {
                    inputArray[i] = new ProductKit(text[0], int.Parse(text[1]), text[2], text[3], text[4]);
                }   
            }
        }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
