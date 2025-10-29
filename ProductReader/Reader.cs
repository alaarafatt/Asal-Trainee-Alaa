using System;
namespace Task
{
    public class Reader
    {
        IValidator validator;
        IProductFactory factory;

        public Reader(IValidator v, IProductFactory f)
        {
            validator = v;
            factory = f;

        }

        public void ManEntry()
        {
            int choice = 1;
            string ch;

            try
            {
                while (choice != 0)
                {

                    Console.WriteLine("enter the product name");
                    string n = Console.ReadLine();

                    Console.WriteLine("enter the product code");
                    string c = Console.ReadLine();

                    Console.WriteLine("enter the product price");
                    string pr = Console.ReadLine();

                    Console.WriteLine("enter the product description");
                    string de = Console.ReadLine();


                    var p = (name: n, code: c, des: de, price: pr);


                    if (validator.Validate(p))
                    {
                        factory.AddProduct(p);

                    }

                    Console.WriteLine("press 0 to exit or 1 to add another product");

                    ch = Console.ReadLine();
                    choice = int.Parse(ch);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("an error happend " + ex.Message);
            }
        }


       



    


        public void Csv()
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

                        var columns = line.Split(',');


                        if (columns.Length == 4)
                        {


                            var p = (name: columns[0], code: columns[1], des: columns[2], Price: columns[3]);

                            if (validator.Validate(p))
                            {
                                factory.AddProduct(p);

                            }
                            else
                            {
                                Console.Write($" in the product name : {columns[0]}\n");
                            }
                        }
                    }

                    break;

                }


                // /Users/alaarafat/Desktop/testcsharp/testcsharp/products.csv


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
                catch (ArgumentNullException)
                {
                    Console.WriteLine("the file should not be empty ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("an error happend in the file " + ex.Message);
                }


            }
        }

    }





}


