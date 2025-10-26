using System;
namespace Task
{
	public class validator
	{
		

		public validator()
		{

		
		}

       public static bool nameValid(string n)
        {
			if(n.Length <= 100 && !string.IsNullOrWhiteSpace(n))
			{
                
				return true;
            }
            Console.WriteLine(" the product name must be not null or less than 100 char");

            return false;
        }


       public static bool codeValid(string c, List<Product> valproduct)
        {
            bool found = false;
            if (c.Length <= 50 && !string.IsNullOrWhiteSpace(c))
            {
                foreach (Product cc in valproduct)
                {
                    if (c == cc.getcode())
                    {
                        Console.Write("\n the product code must be unique");
                        found = true;

                    }
                }

                if (!found)
                {
                    return true;
                }
                else return false;


            }
            else
            {
                Console.WriteLine(" the product code must be not null or less than 100 char");
                return false;
            }
        }

      public static bool priceValid(ref double p, string n)
        {
            if (!string.IsNullOrWhiteSpace(n) && double.TryParse(n, out p))
            {
               
                return true;
            }
            Console.WriteLine(" the product price must be not null and should be int");
            return false;
            
        }

       public static bool desValid(string n)
        {
            if(n.Length <= 500 && !string.IsNullOrWhiteSpace(n))
            {
                return true;
            }
            Console.WriteLine(" the product des must be not null and less or equal to 500 char");
            return false;
        }






    }
}

