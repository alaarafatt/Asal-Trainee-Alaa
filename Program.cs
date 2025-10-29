using System;
namespace Task
{

    class Program
    {


        static void Main(string[] args)
        {

            
            IProductFactory factory = new ProductFactory();
            IValidator validObject = new Validator(factory.GetProducts());

            Reader entry = new Reader(validObject,factory);

            Console.WriteLine("how do u want to enter the products\n 1:manually\n 2:via csv ");
            string x =Console.ReadLine();


            switch (x)
            {
                case "1":entry.ManEntry(); break;
                case "2": entry.Csv();  break;
            }

            factory.PrintAll();

        }

    }

}