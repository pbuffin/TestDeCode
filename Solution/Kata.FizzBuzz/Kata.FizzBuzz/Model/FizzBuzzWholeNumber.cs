namespace Kata.FizzBuzz.Model
{
    public class FizzBuzzWholeNumber : WholeNumber
    {
        private const string FIZZBUZZ_RESPONSE = "FizzBuzz";

        private FizzBuzzWholeNumber(int number) : base(number)
        {
        }

        public static WholeNumber Create(int number)
        {
            return new FizzBuzzWholeNumber(number);
        }

        public override string ToString()
       => FIZZBUZZ_RESPONSE;
    }
}
