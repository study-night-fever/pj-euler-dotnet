using ProjectEuler.Web.Models.Abstracts;
using System.Collections.Generic;

namespace ProjectEuler.Web.Models
{
    public class IndexViewModel : BaseViewModel
    {
        public IEnumerable<ProblemInfo> Problems { get; set; }
    }
}
