namespace FizzBuzzPop.Domain
{
    public class IsDivisibleByFive : IsDivisibleByNumber
    {
        public IsDivisibleByFive() : base("Buzz", new DivisibleByFive())
        {
        }
    }
}