using System;
using Xunit;
using Task1;

namespace Task1Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2008)]
        [InlineData(2000)]
        [InlineData(1912)]
        [InlineData(4)]
        public void TestTrue(int a)
        {
            Program prog = new Program();
            bool test1 = prog.leapYear(a);
            Assert.True(test1);

        }
        [Theory]
        [InlineData(1900)]
        [InlineData(1800)]
        [InlineData(2001)]
        [InlineData(1)]
        public void TestFalse(int a)
        {
            Program prog = new Program();
            bool test1 = prog.leapYear(a);
            Assert.False(test1);

        }
        [Theory]
        [InlineData(-200)]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        public void TestException(int a)
        {
            Program prog = new Program();
            Assert.Throws<ArgumentOutOfRangeException>(() => prog.leapYear(a));
        }
    }
}
