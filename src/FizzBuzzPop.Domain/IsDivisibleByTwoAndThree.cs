namespace FizzBuzzPop.Domain
{
    public class IsDivisibleByTwoAndThree : IsDivisibleByNumber
    {
        public IsDivisibleByTwoAndThree() : base("FizzPop", new DivisibleByTwo(), new DivisibleByThree())
        {
        }
    }
}