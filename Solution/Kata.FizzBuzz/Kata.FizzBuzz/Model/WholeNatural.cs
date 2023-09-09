namespace Kata.FizzBuzz.Model
{
    public abstract class WholeNatural
    {
        private const int DEFAULT_NUMBER = 1;

        protected WholeNatural(int number)
        {
            Number = number;
        }

        protected WholeNatural()
        {
            Number = DEFAULT_NUMBER;
        }

        protected int Number { get; }       
    }
}
