using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Charity.Mvc.Models;
using Charity.Mvc.Services;
using Charity.Mvc.Context;

namespace Charity.Mvc.Controllers
{
	public class HomeController : Controller
	{
		public EFContext Context { get; }
		public HomeController(EFContext context)
		{
			Context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult AboutUs()
		{
			return View();
		}
		public IActionResult AboutIdea()
		{
			return View();
		}

		public IActionResult Institutions()
		{
			InstitutionService institutionService = new InstitutionService(Context);
			var model = institutionService.GetAll();
			return View(model);
		}
		public IActionResult Contact()
		{
			return View();
		}
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
