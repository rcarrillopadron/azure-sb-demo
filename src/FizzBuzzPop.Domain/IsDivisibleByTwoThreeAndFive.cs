namespace FizzBuzzPop.Domain
{
    public class IsDivisibleByTwoThreeAndFive : IsDivisibleByNumber
    {
        public IsDivisibleByTwoThreeAndFive() : base("FizzBuzzPop", new IsDivisibleByTwo(), new IsDivisibleByThree(), new IsDivisibleByFive())
        {
        }
    }
}