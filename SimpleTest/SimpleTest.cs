using System;
using Xunit;

namespace SimpleTest
{
    public class SimpleTest
    {
        [Fact]
        public void Test1()
        {
			Assert.True(1 == 1);
        }
    }
}
