using System;

namespace ProjectEuler.Web.Domains.Problem.Abstracts
{
    public class ProblemInfo : IProblemInfo
    {
        public int Id { get; private set; }

        public string Title { get; private set; }

        public string ContentHtml { get; private set; }

        public Uri OriginalPage { get; private set; }

        public class Builder
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string ContentHtml { get; set; }
            public Uri OriginalPage { get; set; }

            public ProblemInfo Build() => new ProblemInfo
            {
                Id = Id,
                Title = Title,
                ContentHtml = ContentHtml,
                OriginalPage = OriginalPage,
            };
        }
    }
}
