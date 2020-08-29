using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Edura_ETicaret.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }
		

		public string Image { get; set; }

		public bool IsApproved { get; set; }
		public bool IsFeatured { get; set; }
		public bool IsHome { get; set; }

	}
}