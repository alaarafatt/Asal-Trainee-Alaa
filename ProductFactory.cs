
using System;
namespace Task
{
	public class ProductFactory
	{
        private List<Product> products;

        public ProductFactory()
		{
			products = new List<Product>();
		}
		public void AddProduct((string name, string code, string des, string price) p)
		{
			try
			{

				products.Add(new Product(p.name, p.code, p.des, double.Parse(p.price)));
				Console.WriteLine($"\n product : {p.name} was added");

			}

			catch(Exception ex)
			{
				Console.WriteLine("an error happend " + ex.Message);
			}

		}

		public void PrintAll()
		{
			foreach(Product x in products)
			{
				x.Print();
			}
		}
		public List<Product> GetProducts()
		{
			return products;
		}
		  
	}


}

