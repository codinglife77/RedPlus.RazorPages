using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RedPlusTest.Models;
using RedPlusTest.Services;
using System.Collections.Generic;

namespace RedPlusTest.Pages.Portfolios
{
    public class IndexModel : PageModel
    {
		private readonly PortfolioServiceJsonFile _service;

		public IndexModel(PortfolioServiceJsonFile service)
		{
			this._service = service;
		}
		public IEnumerable<Portfolio> Portfolios { get; private set; }
		public void OnGet()
        {
			Portfolios = _service.GetPortfolios();
        }
    }
}
