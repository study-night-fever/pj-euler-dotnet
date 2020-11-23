using ProjectEuler.Web.Models;
using System.Threading.Tasks;
using Xunit;

namespace ProjectEuler.Web.Tests.Models
{
    public class ProblemInfoTest
    {
        [Theory]
        [InlineData(1, "Multiples of 3 and 5")]
        [InlineData(2, "Even Fibonacci numbers")]
        public async Task GetAsync(int id, string title)
        {
            var info = await ProblemInfos.GetAsync(id);
            Assert.Equal(id, info.Id);
            Assert.Equal(title, info.Title);
        }
    }
}
