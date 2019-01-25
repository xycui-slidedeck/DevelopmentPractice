using System;
using Xunit;

namespace ComputeLib.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var numCompute  = new NumCompute();
            var value = numCompute.ComputeAdd(new[] {1, 2});

            Assert.Equal(value,3);
        }
    }
}
