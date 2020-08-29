using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Edura_ETicaret.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual List<Product> Products { get; set; }
	}
}