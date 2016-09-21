using ReactNETDashboard.Models.ViewModels;
using ReactNETDashboard.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactNETDashboard.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var model = new DashboardVM(new DataStore());

			return View(model);
		}
	}
}