using System;
namespace Task

{
	public interface IValidator
	{
        bool Validate((string name, string code, string des, string price) prod);
        bool NameValid(string n);
        bool CodeValid(string c);
        bool PriceValid( string n);
        bool DesValid(string n);

    }
}

