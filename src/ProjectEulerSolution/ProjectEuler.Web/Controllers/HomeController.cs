using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectEuler.Web.Controllers.Abstracts;
using ProjectEuler.Web.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjectEuler.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILogger<HomeController> logger)
            : base(logger)
        {
        }

        public async Task<IActionResult> IndexAsync()
        {
            return View(new IndexViewModel
            {
                Problems = await ProblemInfos.ListAsync(),
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
