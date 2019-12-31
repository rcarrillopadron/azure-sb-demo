namespace FizzBuzzPop.Domain
{
    public class DivisibleByThree : IDivisibleBy
    {
        public bool IsDivisibleBy(int number)
        {
            bool isDivisibleBy3 = number % 3 == 0;
            return isDivisibleBy3;
        }
    }
}