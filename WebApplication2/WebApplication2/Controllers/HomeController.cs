using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Common;
using WebApplication1.Service;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;
        public ITestService TestService { get; set; }
        public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
             //TestService.Show();
            LogLevelConfigruaton zhi = configuration.GetSection("Logging:LogLevel").Get<LogLevelConfigruaton>();
            Console.WriteLine(zhi.Default+"--"+zhi.Microsoft);
            _logger.LogInformation("开启记录日志操作..");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}