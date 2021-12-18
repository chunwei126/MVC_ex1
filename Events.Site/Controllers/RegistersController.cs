using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Events.Site.Models.EFModels;
using Events.Site.Models.Services;
using Events.Site.Models.ViewModels;

namespace Events.Site.Controllers
{
	public class RegistersController : Controller
	{
		private RegisterService service = new RegisterService();

		public ActionResult Index()
		{
			return View(service.GetAll());
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(RegisterCreateVM model)
		{
			if (ModelState.IsValid)
			{
				try
				{
					service.Create(model);

					return RedirectToAction("Index");
				}
				catch (Exception ex)
				{
					Console.WriteLine("NAME錯誤:" + ex.Message);
				}
			}

			return View(model);
		}
	}
}
