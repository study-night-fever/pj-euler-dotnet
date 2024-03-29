﻿using ProjectEuler.Web.Domains.Problem.Abstracts;
using System.Threading.Tasks;
using Xunit;

namespace ProjectEuler.Web.Tests.Domains.Problem
{
    public class IProblemInfoTest
    {
        [Theory]
        [InlineData(1, "Multiples of $3$ or $5$")]
        [InlineData(2, "Even Fibonacci Numbers")]
        public async Task GetAsync(int id, string title)
        {
            var info = await IProblemInfo.GetAsync(id);
            Assert.Equal(id, info.Id);
            Assert.Equal(title, info.Title);
        }
    }
}
