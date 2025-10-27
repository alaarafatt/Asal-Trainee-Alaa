using System;
namespace Task
{
	public interface IProductFactory
	{

        void AddProduct((string name, string code, string des, double price) p);
        void PrintAll();

    }
}

