namespace Kata.FizzBuzz.Model
{
    public class BuzzWholeNatural : WholeNatural
    {
        private const string BUZZ_RESPONSE = "Buzz";

        private BuzzWholeNatural(int number) : base(number)
        {
        }

        public static BuzzWholeNatural Create(int number)
        {
            return new BuzzWholeNatural(number);
        }

        public override string ToString()
        => BUZZ_RESPONSE;
    }
}
