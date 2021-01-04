using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectEuler.Problem1;
using ProjectEuler.Web.Controllers.Abstracts;
using ProjectEuler.Web.Models.Problems;

namespace ProjectEuler.Web.Controllers
{
    public class Problem1Controller : BaseController
    {
        private readonly ICalculator _calculator;

        public Problem1Controller(ILogger<Problem1Controller> logger, ICalculator calculator)
            : base(logger)
        {
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            return View(new Problem1ViewModel
            {
            });
        }

        public IActionResult Submit()
        {
            return View(new Problem1ViewModel
            {

            });
        }
    }
}
