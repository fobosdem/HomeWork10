using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageAndProducts;

namespace ConsoleAppHome10
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				Console.WriteLine("Hello here you can add new storages and fill it with new products");
				Console.WriteLine("1 - Add new storage");
				Console.WriteLine("2 - Add new products to some storage");
				Console.WriteLine("3 - output all storages with products");
				int menu = 0;
				do
				{
					Console.Write("Menu: ");
				} while (!int.TryParse(Console.ReadLine(), out menu) || menu == 0);

				switch (menu)
				{
					case 1:
						Storage.CreatingStorage();
						break;
					case 2:
						Product.AddingProduct();
						break;
					case 3:
						foreach (Storage storage in TempSaverClass.Storages)
						{
							Console.WriteLine(storage.ToString());
						}
						break;
				}
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}
