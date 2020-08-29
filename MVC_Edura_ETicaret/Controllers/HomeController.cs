using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Edura_ETicaret.Models;

namespace MVC_Edura_ETicaret.Controllers
{
    public class HomeController : Controller
    {
		MVC_Edura_ETicaretContext _context = new MVC_Edura_ETicaretContext();
		// GET: Home
		public ActionResult Index()
        {
			var products = _context
				.Products
				.Where(i => i.IsApproved == true && i.IsHome == true)
				.ToList();
            return View(products);
        }
    }
}