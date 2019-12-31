namespace FizzBuzzPop.Domain
{
    public class IsDivisibleByThree : IsDivisibleByNumber
    {
        public IsDivisibleByThree() : base("Fizz", new DivisibleByThree())
        {
        }
    }
}