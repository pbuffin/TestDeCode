namespace Kata.FizzBuzz.Model
{
    public abstract class WholeNumber
    {
        private const int DEFAULT_NUMBER = 1;

        protected WholeNumber(int number)
        {
            Number = number;
        }

        protected WholeNumber()
        {
            Number = DEFAULT_NUMBER;
        }

        protected int Number { get; }       
    }
}
