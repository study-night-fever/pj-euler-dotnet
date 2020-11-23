using ProjectEuler.Web.Models.Abstracts;

namespace ProjectEuler.Web.Models
{
    public class ErrorViewModel : BaseViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
