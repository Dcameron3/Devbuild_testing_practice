using System;
using Xunit;
using TDD_PassWordVerifier;

namespace PasswordVerify_TEST
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("11111", false)]
        [InlineData ("", false)]
        [InlineData ("1oo000", false)]
        [InlineData ("1212ooooOOO", true)]
        [InlineData ("12$$$$$ssss", false)]
        public void TestVerify(string password, bool expected)
        {
            bool actual = Program.Verify(password);
            Assert.Equal(expected, actual);
        }
    }
}
