using System;


namespace Task
{
	public class ManualEntry
	{
        Validator validObject;
        ProductFactory prodFac;

        public ManualEntry(Validator v, ProductFactory f)
		{
            validObject = v;
            prodFac = f;
        }

       public void ManEntry()
        {
            int choice = 1;
            string ch;
            while (choice != 0)
            {


                //  products.Add(new Product(enterName(), enterCode(), enterDescription(), enterPrice()));
                // Console.WriteLine("\n\n the product was added \n\n");

                var p = (name:EnterName(),code:EnterCode(),des:EnterDescription(),price:EnterPrice());

                if (validObject.Validate(p))
                {
                    prodFac.AddProduct(p);

                }

                Console.WriteLine("press 0 to exit or 1 to add another product");

                ch = Console.ReadLine();
                choice = int.Parse(ch);

            }

            prodFac.PrintAll();



        }


        string EnterName()
        {

            Console.WriteLine("enter the product name");
            string n = Console.ReadLine();

            return n;


        }




        string EnterCode()
        {

            Console.WriteLine("enter the product code");
            string c = Console.ReadLine();

            return c;
        }




        string EnterPrice()
        {

            Console.WriteLine("enter the product price");
            string pr = Console.ReadLine();

            return pr;

        }



        string EnterDescription()
        {

            Console.WriteLine("enter the product description");
            string de = Console.ReadLine();

            return de;

        }



    }
}

