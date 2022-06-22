using Microsoft.AspNetCore.Hosting;
using RedPlusTest.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace RedPlusTest.Services
{
    public class PortfolioServiceJsonFile
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PortfolioServiceJsonFile(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get
            {
                //return _webHostEnvironment.WebRootPath + "\\Portfolios\\portfolios.json";
                return Path.Combine(_webHostEnvironment.WebRootPath, "Portfolios", "portfolios.json");
            }
        }
        public IEnumerable<Portfolio> GetPortfolios()
        {
            //var jsonFileName = @"D:\Learning\ASP.NET\RedPlus.RazorPages\RedPlusTest\RedPlusTest\wwwroot\Portfolios\portfolios.json";
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                var portfoios = JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(), options);
                return portfoios;
            }
        }
    }
}
