namespace FizzBuzzPop.Domain
{
    public class IsDivisibleByTwoAndFive : IsDivisibleByNumber
    {
        public IsDivisibleByTwoAndFive() : base("BuzzPop", new DivisibleByTwo(), new DivisibleByFive())
        {
        }
    }
}