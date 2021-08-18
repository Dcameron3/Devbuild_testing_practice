using System;
using Xunit;
using DevBuild_Lab_TDD;

namespace StringAdd_TEST
{
    public class UnitTest1
    {


        [Theory]
        [InlineData("1, 2, 3\n6", 12)]
        [InlineData("56, 34, 101", 191)]
        public void TestAdd(string numbers, int expected)
        {
            int actual = StringToBuild.Add(numbers);
            Assert.Equal(expected, actual);
        }

    }
}

