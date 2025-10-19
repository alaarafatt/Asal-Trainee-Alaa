using System;


namespace Task
{


    public class Product
    {

        public string name;
        public int code;
        public string description;
        public double price;

        public Product(string name, int code, string description, double price)
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

    }


    class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            string ch;
            List<Product> products = new List<Product>();

            while (choice != 0)
            {
                Console.WriteLine("enter the product name");
                string n = Console.ReadLine();
                Console.WriteLine("enter the product code");
                string sc = Console.ReadLine();
                int c = int.Parse(sc);
                Console.WriteLine("enter the product description");
                string de = Console.ReadLine();
                Console.WriteLine("enter the product price");
                string sp = Console.ReadLine();
                double p = double.Parse(sp);

                products.Add(new Product(n, c, de, p));
                Console.WriteLine("the product was added");
                Console.WriteLine("press 0 to exit or 1 to add another product");

                ch = Console.ReadLine();
                choice = int.Parse(ch);









            }

            foreach(Product x in products)
            {
                x.print();
            }


        }

    }



}