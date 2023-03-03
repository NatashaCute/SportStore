using Microsoft.AspNetCore.Mvc;

namespace Natasha_SportStore.Controllers
{
	public class HomeController: Controller
	{
		public IActionResult Index() => View();
	}
}
