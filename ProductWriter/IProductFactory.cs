using System;
namespace Task
{
	public interface IProductFactory
	{

        void AddProduct((string name, string code, string des, string price) p);
        void PrintAll();
        public List<Product> GetProducts();
    }
}

