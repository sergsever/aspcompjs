using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspcompjs.ViewComponents
{
	public class Jscomp :ViewComponent
	{
		public Jscomp()
		{
			
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
