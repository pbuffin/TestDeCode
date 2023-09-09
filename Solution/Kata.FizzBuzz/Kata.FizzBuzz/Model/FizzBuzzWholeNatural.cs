namespace Kata.FizzBuzz.Model
{
    public class FizzBuzzWholeNatural : WholeNatural
    {
        private const string FIZZBUZZ_RESPONSE = "FizzBuzz";

        private FizzBuzzWholeNatural(int number) : base(number)
        {
        }

        public static WholeNatural Create(int number)
        {
            return new FizzBuzzWholeNatural(number);
        }

        public override string ToString()
       => FIZZBUZZ_RESPONSE;
    }
}
