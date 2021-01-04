using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectEuler.Web.Controllers.Abstracts;
using ProjectEuler.Web.Models;
using ProjectEuler.Web.Models.Abstracts;
using ProjectEuler.Web.Models.Problems;
using System;
using System.Threading.Tasks;

namespace ProjectEuler.Web.Controllers
{
    public class ProblemsController : BaseController
    {
        public ProblemsController(ILogger<ProblemsController> logger) : base(logger)
        {
        }

        public async Task<IActionResult> IndexAsync(int id)
        {
            var viewModel = new Func<IProblemViewModel>(() =>
            {
                return id switch
                {
                    1 => new Problem1ViewModel(),
                    2 => new Problem2ViewModel(),
                    _ => throw new NotImplementedException($"未実装の問題です。[id: {id}]"),
                };
            })();

            viewModel.ProblemInfo = await ProblemInfos.GetAsync(id);

            return View($"~/Views/Problems/{id}.cshtml", viewModel);
        }
    }
}
