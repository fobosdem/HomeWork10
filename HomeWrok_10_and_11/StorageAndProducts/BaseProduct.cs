using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAndProducts
{
	public class BaseProduct
	{
		public string Type { get; set; }
		public int Life { get; set; }

		public BaseProduct(string type, int life)
		{
			Type = type;
			Life = life;
		}
	}
}
