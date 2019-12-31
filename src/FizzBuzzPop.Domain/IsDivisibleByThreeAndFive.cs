namespace FizzBuzzPop.Domain
{
    public class IsDivisibleByThreeAndFive : IsDivisibleByNumber
    {
        public IsDivisibleByThreeAndFive() : base("FizzBuzz", new DivisibleByThree(), new DivisibleByFive())
        {
        }
    }
}