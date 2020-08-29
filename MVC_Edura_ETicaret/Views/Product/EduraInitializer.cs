using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_Edura_ETicaret.Models;

namespace MVC_Edura_ETicaret.Views.Product
{
	public class EduraInitializer : DropCreateDatabaseAlways<MVC_Edura_ETicaretContext>
	{
		protected override void Seed(MVC_Edura_ETicaretContext context)
		{
			List<Category> kategoriler = new List<Category>()
			{
				new Category() {Name="Furniture"},
				new Category() {Name="Electronics"},
				new Category() {Name="Books"},
				new Category() {Name="Accessories"},
				new Category() {Name="Computers"},
				new Category() {Name="Camera"}
			};
			foreach (var item in kategoriler)
			{
				context.Categories.Add(item);
			}
			context.SaveChanges();

			List<MVC_Edura_ETicaret.Models.Product> urunler = new List<MVC_Edura_ETicaret.Models.Product>()
			{
				new MVC_Edura_ETicaret.Models.Product() {Name="Photo Camera", Image="Product1.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus." , IsApproved=true,IsFeatured=true,IsHome=true,Price=99,CategoryId=6},
				new MVC_Edura_ETicaret.Models.Product() {Name="Comfortable Sofa", Image="Product3.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus." , IsApproved=true,IsFeatured=true,IsHome=true,Price=99,CategoryId=3},
				new MVC_Edura_ETicaret.Models.Product() {Name="Hand Bag", Image="Product4.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus." , IsApproved=true,IsFeatured=true,Price=99,IsHome=true,CategoryId=1},
				new MVC_Edura_ETicaret.Models.Product() {Name="Photo Camera", Image="Product1.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus." , IsApproved=true,IsFeatured=true,Price=99,IsHome=true,CategoryId=2},
				new MVC_Edura_ETicaret.Models.Product() {Name="Photo Camera", Image="Product1.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus." , IsApproved=true,IsFeatured=true,Price=99,IsHome=false,CategoryId=2},
				new MVC_Edura_ETicaret.Models.Product() {Name="Photo Camera", Image="Product1.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus." , IsApproved=true,IsFeatured=true,Price=99,IsHome=false,CategoryId=2},
				new MVC_Edura_ETicaret.Models.Product() {Name="Photo Camera", Image="Product1.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus." , IsApproved=true,IsFeatured=true,Price=99,IsHome=true,CategoryId=2},
				new MVC_Edura_ETicaret.Models.Product() {Name="Photo Camera", Image="Product1.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus." , IsApproved=true,IsFeatured=true,Price=99,IsHome=false,CategoryId=2}
			};

			foreach (var item in urunler)
			{
				context.Products.Add(item);
			}
			context.SaveChanges();

			base.Seed(context);
		}
	}
}