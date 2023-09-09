namespace Kata.FizzBuzz.Model
{
    public class NormalWholeNumber : WholeNumber
    {
        private NormalWholeNumber() : base()
        {

        }

        private NormalWholeNumber(int number) : base(number)
        {
        }

        public static NormalWholeNumber Create(int number)
        {
            return new NormalWholeNumber(number);
        }

        public static WholeNumber Create()
        {
            return new NormalWholeNumber();
        }

        public override string ToString()
        => Number.ToString();
    }
}
