using System;
using System.ComponentModel.DataAnnotations;

namespace Task
{
	public class CsvEntry
	{
        Validator validator ;
        ProductFactory factory;

		public CsvEntry(Validator v , ProductFactory f )
		{

            validator = v;
            factory = f;
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


                        var p = (name: columns[0], code: columns[1], des: columns[2], Pri: columns[3]);

                        if (validator.Validate(p))
                        {
                            factory.AddProduct(p);
                            
                        }
                        else
                        {
                            Console.Write($" in the product name : {columns[0]}\n");
                        }
                    }

                    factory.PrintAll();

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
                    Console.WriteLine("the file should not be empty " );
                }
                catch (Exception ex)
                {
                    Console.WriteLine("an error happend in the file " + ex.Message);
                }
               

            }
        }

    }
}

