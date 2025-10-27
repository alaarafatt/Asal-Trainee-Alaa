using System;


namespace Task
{

    class Program
    {


        static void Main(string[] args)
        {

            
            ProductFactory factory = new ProductFactory();
            Validator validObject = new Validator(factory.GetProducts());

            Console.WriteLine("how do u want to enter the products\n 1:manually\n 2:via csv ");
            string x =Console.ReadLine();

           

            switch (x)
            {
                case "1":new ManualEntry(validObject,factory).ManEntry() ;break;
                case "2": new CsvEntry(validObject, factory).Csv(); break;
            }



        }

    }

}