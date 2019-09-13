using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public class Product
    {
        private decimal _price;
        private int _amount;
        private string _name;

        public Product(string name, decimal priceAtStart, int amountAtStart)
        {
            this._name = name;
            this._amount = amountAtStart;
            this._price = priceAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price {string.Format("{0:0.00}", _price)} EUR, amount {_amount} units");
        }

        public void updatePrice(decimal newPrice)
        {
            _price = newPrice;
        }

        public void decreaseAmount()
        {
            _amount--;
        }
    }

}
