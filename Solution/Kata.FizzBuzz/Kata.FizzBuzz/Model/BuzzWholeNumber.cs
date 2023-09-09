namespace Kata.FizzBuzz.Model
{
    public class BuzzWholeNumber : WholeNumber
    {
        private const string BUZZ_RESPONSE = "Buzz";

        private BuzzWholeNumber(int number) : base(number)
        {
        }

        public static BuzzWholeNumber Create(int number)
        {
            return new BuzzWholeNumber(number);
        }

        public override string ToString()
        => BUZZ_RESPONSE;
    }
}
