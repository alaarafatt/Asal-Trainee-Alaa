using System;

namespace Task
{
    public class Product
    {

        private string name;
        private string code;
        private string description;
        private double price;

        public Product(string name, string code, string description, double price)
        {
            this.code = code;
            this.name = name;
            this.description = description;
            this.price = price;

        }

        public void print()
        {
            Console.WriteLine($"\n\n\nthe product name : {name}\n product code : {code} \n product description {description}\n product price {price}\n\n\n");
        }

        public string getcode()
        {
            return code;
        }
    }
}
