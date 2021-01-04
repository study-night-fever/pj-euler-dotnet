using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ProjectEuler.Web.Pages
{
    public abstract class BasePageModel : PageModel
    {
        protected readonly ILogger _logger;

        protected BasePageModel(ILogger logger)
        {
            _logger = logger;
        }
    }
}
