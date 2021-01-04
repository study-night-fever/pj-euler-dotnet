using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ProjectEuler.Web.Pages.Problems
{
    public class Problem2PageModel : BaseProblemPageModel
    {
        public override int ProblemId => 2;

        public Problem2PageModel(ILogger<Problem2PageModel> logger)
            : base(logger)
        {
        }

        public async Task OnGetAsync()
        {
            await Task.Run(() =>
            {
                // do nothing
            });
        }
    }
}
