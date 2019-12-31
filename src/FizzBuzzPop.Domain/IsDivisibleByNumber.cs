using System.Linq;

namespace FizzBuzzPop.Domain
{
    public abstract class IsDivisibleByNumber : IDivisibleBy
    {
        public string Message { get; }
        private readonly IDivisibleBy[] _matchers;

        protected IsDivisibleByNumber(string message, params IDivisibleBy[] matchers)
        {
            Message = message;
            _matchers = matchers;
        }


        public bool IsDivisibleBy(int number) => _matchers.All(x => x.IsDivisibleBy(number));
    }
}