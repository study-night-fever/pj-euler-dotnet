using System;
using System.Text.RegularExpressions;

namespace ProjectEuler.Web.Domains.Problem.Abstracts
{
    public class ProblemInfo : IProblemInfo
    {
        public int Id { get; private set; }

        public string Title { get; private set; }

        public string EncodedTitle => _Encode(Title);

        public string ContentHtml { get; private set; }

        public string EncodedContentHtml => _Encode(ContentHtml);

        public Uri OriginalPage { get; private set; }

        private string _Encode(string text)
        {
            var result = text;
            result = Regex.Replace(result, @"\$\$([^$]+)\$\$", "<center><b>$1</b></center>");
            result = Regex.Replace(result, @"\$([^$]+)\$", "<b>$1</b>");
            result = Regex.Replace(result, @"\\dots", "...");
            return result;
        }

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
