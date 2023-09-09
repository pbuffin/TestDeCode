namespace Kata.FizzBuzz.Model
{
    public class FizzWholeNatural : WholeNatural
    {
        private const string FIZZ_REPONSE = "Fizz";

        private FizzWholeNatural(int number) : base(number)
        {
        }

        public static FizzWholeNatural Create(int number)
        {
            return new FizzWholeNatural(number);
        }

        public override string ToString()
       => FIZZ_REPONSE;
    }
}
