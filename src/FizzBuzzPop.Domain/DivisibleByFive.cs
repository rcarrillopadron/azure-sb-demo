namespace FizzBuzzPop.Domain
{
    public class DivisibleByFive : IDivisibleBy
    {
        public bool IsDivisibleBy(int number)
        {
            bool isDivisibleBy5 = number % 5 == 0;
            return isDivisibleBy5;
        }
    }
}