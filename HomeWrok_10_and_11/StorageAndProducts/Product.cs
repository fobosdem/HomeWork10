using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAndProducts
{
	public class Product : BaseProduct
	{
		public string Name { get; set; }
		public int Price { get; set; }
		public string EndShelfLife { get; set; }
		public Product(string name, int price, string startDateTime, string type, int life) : base (type, life)
		{
			Name = name;
			Price = price;
			EndShelfLife = GetShelfLife(startDateTime);

		}

		public string GetShelfLife(string startDateTime)
		{
			int[] dateFormat = new int[3];
			int j = 0;
			foreach (string eachNumber in startDateTime.Split('.'))
			{
				dateFormat[j] = int.Parse(eachNumber);
				j++;
			}


			dateFormat[0] += this.Life;
			if(dateFormat[0] > 30)
			{
				dateFormat[1] += 1;
				dateFormat[0] -= 30;
			}
			if(dateFormat[1] > 12)
			{
				dateFormat[2] += 1;
				dateFormat[1] -= 12;
			}

			string result = "";
			for (int i = 0; i < 3; i++)
			{
				if (i != 2)
				{
					result += dateFormat[i] + ".";
				}
				else result += $"{dateFormat[i]}";
			}
			return result;
		}

		public static void AddingProduct()
		{
			Console.WriteLine("Chose to what storage you want add products:");
			int i = 0;
			foreach (var storage in TempSaverClass.Storages)
			{
				Console.WriteLine($"{i} - {storage.Name}");
				i++;
			}

			int numberOfStorage = int.Parse(Console.ReadLine());

			string typeOfProduct;
			int lifeOfProduct = 0;
			string nameOfProduct;
			int priceOfProduct;
			string startingDateOfProduct;

			Console.Write("Product Type: ");
			typeOfProduct = Console.ReadLine();

			Console.Write("Product life in days (1, 2, 3):");
			lifeOfProduct = int.Parse(Console.ReadLine());

			Console.Write("Name of Product: ");
			nameOfProduct = Console.ReadLine();

			Console.Write("Price of Product: ");
			priceOfProduct = int.Parse(Console.ReadLine());

			Console.Write("Date of starting storage (in format: d.m.y): ");
			startingDateOfProduct = Console.ReadLine();

			Product tempProduct = new Product(nameOfProduct, priceOfProduct, startingDateOfProduct, typeOfProduct, lifeOfProduct);

			TempSaverClass.Storages[numberOfStorage].AddingProduct(tempProduct);
		}
		public override string ToString()
		{
			return $"Product: {Name}, Price: {Price}, End of Shelf Life: {EndShelfLife}";
		}
	}
}
