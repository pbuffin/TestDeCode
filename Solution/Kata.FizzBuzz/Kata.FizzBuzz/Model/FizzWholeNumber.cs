namespace Kata.FizzBuzz.Model
{
    public class FizzWholeNumber : WholeNumber
    {
        private const string FIZZ_REPONSE = "Fizz";

        private FizzWholeNumber(int number) : base(number)
        {
        }

        public static FizzWholeNumber Create(int number)
        {
            return new FizzWholeNumber(number);
        }

        public override string ToString()
       => FIZZ_REPONSE;
    }
}
