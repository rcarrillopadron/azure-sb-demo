namespace FizzBuzzPop.Domain
{
    public class DivisibleByTwo : IDivisibleBy
    {
        public bool IsDivisibleBy(int number)
        {
            bool isDivisibleBy2 = number % 2 == 0;
            return isDivisibleBy2;
        }
    }
}