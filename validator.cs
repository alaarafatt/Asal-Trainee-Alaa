using System;
namespace Task
{
	public class Validator : IValidator
	{
        private List<Product> _products;
        
        public Validator(List<Product> products)
		{
            _products = products;
		
		}

        public  bool Validate((string name ,string code, string des, string price) prod )
        {

            return NameValid(prod.name) && CodeValid(prod.code)&& DesValid(prod.des)&& PriceValid(prod.price);

        }

       public  bool NameValid(string n)
        {
			if(n.Length <= 100 && !string.IsNullOrWhiteSpace(n))
			{
                
				return true;
            }
            Console.WriteLine(" the product name must be not null or less than 100 char");

            return false;
        }


       public  bool CodeValid(string c)
        {
            bool found = false;
            if (c.Length <= 50 && !string.IsNullOrWhiteSpace(c))
            {
                foreach (Product cc in _products)
                {
                    if (c == cc.GetCode())
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

      public  bool PriceValid(string n)
        {
            if (!string.IsNullOrWhiteSpace(n) && double.TryParse(n,out double number))
            {
               
                return true;
            }
            Console.WriteLine(" the product price must be not null and should be int");
            return false;
            
        }

       public  bool DesValid(string n)
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

