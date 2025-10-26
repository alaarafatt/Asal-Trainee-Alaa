using System;


namespace Task
{

    class Program
    {


        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            Console.WriteLine("how do u want to enter the products\n 1:manually\n 2:via csv ");
            string x =Console.ReadLine();

           

            switch (x)
            {
                case "1":manualEntry();break;
                case "2":csvEntry(); break;

            }



            void csvEntry()
            {
               
                while (true)
                {
                    Console.WriteLine("enter the file path ");
                    string fname = Console.ReadLine();

                    try
                    {
                        var lines = File.ReadAllLines(fname).Skip(1);

                        foreach (var line in lines)
                        {
                            
                            double x = 0;
                            var columns = line.Split(',');
                            if (validator.nameValid(columns[0]) && validator.codeValid(columns[1], products) && validator.desValid(columns[2]) && validator.priceValid(ref x, columns[3]))
                            {
                                products.Add(new Product(columns[0], columns[1], columns[2], x));
                            }
                            else
                            {
                                Console.Write($" in the product name :  {columns[0]}\n\n");
                            }


                        }


                        foreach (Product x in products)
                        {
                            x.print();
                        }


                        break;  // /Users/alaarafat/Desktop/testcsharp/testcsharp/products.csv
                    }

                    catch (FileNotFoundException)
                    {
                        Console.WriteLine(" file not found ");
                    }
                    catch (NotSupportedException)
                    {
                        Console.WriteLine("not supported ");
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("cant read or write  ");
                    }

                }
            }
   




            string enterName()
            {
                while (true)
                {
                    Console.WriteLine("enter the product name");
                    string n = Console.ReadLine();
                    if (validator.nameValid(n))
                    {
                        return n;
                    }
               
                }

            }




            string enterCode()
            {
               
                while (true)
                {
                    
                    Console.WriteLine("enter the product code");
                    string c = Console.ReadLine();
                    
                        if (validator.codeValid(c,products))
                        { 
                            return c;
                        }

                }

            }


           

            double enterPrice()
            {
                double p=0;
                while (true)
                {
                    Console.WriteLine("enter the product price");
                    var n = Console.ReadLine();
                    if (validator.priceValid(ref p,n))
                    {
                        return p;
                    }
              
                }

            }



            string enterDescription()
            {
                while (true)
                {
                    Console.WriteLine("enter the product description");
                    string n = Console.ReadLine();
                    if (validator.desValid(n))
                    {
                        return n;
                    }
              
                }

            }



            void manualEntry()
            {
                int choice = 1;
                string ch;
                while (choice != 0)
                {

                    products.Add(new Product(enterName(), enterCode(), enterDescription(), enterPrice()));
                    Console.WriteLine("\n\n the product was added \n\n");


                    Console.WriteLine("press 0 to exit and print the products or 1 to add another product");

                    ch = Console.ReadLine();
                    choice = int.Parse(ch);

                }


                foreach (Product x in products)
                {
                    x.print();
                }




            }

        }

    }

}