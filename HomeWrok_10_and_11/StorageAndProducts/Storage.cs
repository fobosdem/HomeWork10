using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAndProducts
{
    public class Storage
    {
		public string Name { get; set; }
		public int Space { get; set; }
		public Product[] Products = new Product[0];
		public Storage(string name, int space)
		{
			Name = name;
			Space = space;
		}

		public void AddingProduct(Product product)
		{
			if (Products.Length == Space)
			{
				Console.WriteLine("Chose another storage this is full");
			}
			else
			{
				Array.Resize(ref Products, Products.Length + 1);
				Products[Products.Length - 1] = product;
			}
		}

		public static void CreatingStorage()
		{
			Console.WriteLine("Creating Storage");
			Console.Write("Name: ");
			string storageName = Console.ReadLine();
			int space = 0;
			do
			{
				Console.Write("Space: ");
			} while (!int.TryParse(Console.ReadLine(), out space) || space == 0);
			Storage tempStorage = new Storage(storageName, space);
			TempSaverClass.Storages.Add(tempStorage);
		}

		public override string ToString()
		{
			string result = "";
			result += Name;
			result += "\n\r\t" + Space;
			foreach(var product in Products)
			{
				result += "\n\r\t\t" + product.ToString();
			}
			return result;
		}
	}
}
