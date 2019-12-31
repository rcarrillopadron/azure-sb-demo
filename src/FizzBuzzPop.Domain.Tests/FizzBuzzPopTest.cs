using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace FizzBuzzPop.Domain.Tests
{
    public class FizzBuzzPopTest
    {
        private readonly ITestOutputHelper _output;

        public FizzBuzzPopTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestValues(int number, string expectedValue)
        {
            var fizzBuzzPop = new FizzBuzzPopCalculator();
            string value = FizzBuzzPopCalculator.GetMessage(number);
            value.Should().Be(expectedValue);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { 1, "1" },
                new object[] { 2, "Pop" },
                new object[] { 3, "Fizz" },
                new object[] { 4, "Pop" },
                new object[] { 5, "Buzz" },
                new object[] { 6, "FizzPop" },
                new object[] { 7, "7" },
                new object[] { 8, "Pop" },
                new object[] { 9, "Fizz" },
                new object[] { 10, "BuzzPop" },
                new object[] { 11, "11" },
                new object[] { 12, "FizzPop" },
                new object[] { 30, "FizzBuzzPop" },
            };
    }
}
