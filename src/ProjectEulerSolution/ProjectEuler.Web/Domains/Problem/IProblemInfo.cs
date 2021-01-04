using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler.Web.Domains.Problem.Abstracts
{
    public interface IProblemInfo
    {
        public int Id { get; }

        public string Title { get; }

        public string ContentHtml { get; }

        public Uri OriginalPage { get; }

        private static readonly IEnumerable<int> _ProblemIds = new[]
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
                _list = await Task.WhenAll(_ProblemIds
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
