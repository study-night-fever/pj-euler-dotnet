using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler.Web.Models
{
    public class ProblemInfo
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

    public static class ProblemInfos
    {
        private static readonly IEnumerable<int> ProblemIds = new[]
        {
            1,
            2,
        };

        private static IEnumerable<ProblemInfo> _list;

        public static async Task<ProblemInfo> GetAsync(int id) => (await _PrepareAsync()).ToList().Find(problem => problem.Id == id);

        public static async Task<IEnumerable<ProblemInfo>> ListAsync() => await _PrepareAsync();

        private static async Task<IEnumerable<ProblemInfo>> _PrepareAsync()
        {
            if (_list == null)
            {
                _list = await Task.WhenAll(ProblemIds
                    .Select(async id =>
                    {
                        var uri = new Uri($"https://projecteuler.net/problem={id}");

                        using var context = BrowsingContext.New(Configuration.Default.WithDefaultLoader());
                        using var document = await context.OpenAsync(uri.ToString());

                        return new ProblemInfo.Builder
                        {
                            Id = id,
                            Title = document.QuerySelector("h2").TextContent,
                            ContentHtml = document.QuerySelector(".problem_content").InnerHtml,
                            OriginalPage = uri,
                        }.Build();
                    }));
            }
            return _list;
        }
    }
}
