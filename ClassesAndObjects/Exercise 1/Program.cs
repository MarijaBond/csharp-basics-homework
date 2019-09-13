using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Exercise_1
{

    public class Program
    {
        static void Main(string[] args)
        {


            Product logitechMouse = new Product("Logitech mouse", 70, 14);
            logitechMouse.PrintProduct();
            logitechMouse.decreaseAmount();
            logitechMouse.updatePrice((decimal)69.99);
            logitechMouse.PrintProduct();

            Product iphone5s = new Product("iPhone 5s", 999, 3);
            iphone5s.PrintProduct();
            iphone5s.decreaseAmount();
            iphone5s.updatePrice((decimal)1000);
            iphone5s.PrintProduct();

            Product epson = new Product("Epson EB-U05", 440, 1);
            epson.PrintProduct();
            epson.decreaseAmount();
            epson.updatePrice((decimal)399.99);
            epson.PrintProduct();

        }
    }
}

