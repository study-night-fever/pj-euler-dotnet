using Microsoft.Extensions.Logging;
using ProjectEuler.Web.Domains.Problem.Abstracts;
using System.Threading.Tasks;

namespace ProjectEuler.Web.Pages
{
    public abstract class BaseProblemPageModel : BasePageModel
    {
        protected BaseProblemPageModel(ILogger logger)
            : base(logger)
        {
        }

        public abstract int ProblemId { get; }

        public async Task<IProblemInfo> GetProblemInfoAsync()
        {
            return await IProblemInfo.GetAsync(ProblemId);
        }
    }
}
