using Kata.FizzBuzz.Model;

namespace Kata.FizzBuzz.Factories
{
    public class WholeNaturalFactory
    {
        public static WholeNatural CreateDefault()
        {
            return NormalWholeNatural.Create();
        }

        public static WholeNatural Create(int number)
        => number switch
             {
                 int n when n % 3 == 0 && n % 5 == 0 => FizzBuzzWholeNatural.Create(number),
                 int n when n % 3 == 0 => FizzWholeNatural.Create(number),
                 int n when n % 5 == 0 => BuzzWholeNatural.Create(number),
                 _ => NormalWholeNatural.Create(number),
             };

    }
}
