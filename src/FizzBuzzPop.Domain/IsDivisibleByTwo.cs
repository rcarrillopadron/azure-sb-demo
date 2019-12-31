namespace FizzBuzzPop.Domain
{
    public class IsDivisibleByTwo : IsDivisibleByNumber
    {
        public IsDivisibleByTwo() : base("Pop", new DivisibleByTwo())
        {
        }
    }
}