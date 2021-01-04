namespace ProjectEuler.Web.Models.Abstracts
{
    public abstract class BaseProblemViewModel : IProblemViewModel
    {
        public ProblemInfo ProblemInfo { get; set; }
    }
}
