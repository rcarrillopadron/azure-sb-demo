using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzPop.Domain
{
    public class FizzBuzzPopCalculator
    {
        private static IEnumerable<IsDivisibleByNumber> Instances => new IsDivisibleByNumber[]
        {
            new IsDivisibleByTwoThreeAndFive(),
            new IsDivisibleByTwoAndFive(),
            new IsDivisibleByTwoAndThree(),
            new IsDivisibleByThreeAndFive(),
            new IsDivisibleByThree(),
            new IsDivisibleByFive(),
            new IsDivisibleByTwo()
        };

        public static string GetMessage(int value)
        {
            var first = Instances.FirstOrDefault(x => x.IsDivisibleBy(value));

            if (first != null)
                return first.Message;

            return value.ToString();
        }
    }
}
