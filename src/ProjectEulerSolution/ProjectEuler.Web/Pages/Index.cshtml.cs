using Microsoft.Extensions.Logging;
using ProjectEuler.Web.Domains.Problem.Abstracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectEuler.Web.Pages
{
    public class IndexPageModel : BasePageModel
    {
        public IEnumerable<IProblemInfo> Problems { get; private set; }

        public IndexPageModel(ILogger<IndexPageModel> logger)
            : base(logger)
        {
        }

        public async Task OnGetAsync()
        {
            Problems = await IProblemInfo.ListAsync();
        }
    }
}
