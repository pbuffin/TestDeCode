using Kata.FizzBuzz.Model;

namespace Kata.FizzBuzz.Factories
{
    public class WholeNumberFactory
    {
        public static WholeNumber CreateDefault()
        {
            return NormalWholeNumber.Create();
        }

        public static WholeNumber Create(int number)
        => number switch
             {
                 int n when n % 3 == 0 && n % 5 == 0 => FizzBuzzWholeNumber.Create(number),
                 int n when n % 3 == 0 => FizzWholeNumber.Create(number),
                 int n when n % 5 == 0 => BuzzWholeNumber.Create(number),
                 _ => NormalWholeNumber.Create(number),
             };

    }
}
