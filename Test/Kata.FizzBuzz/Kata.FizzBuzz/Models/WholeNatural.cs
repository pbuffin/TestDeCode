using Kata.FizzBuzz.Extensions;


namespace Kata.FizzBuzz.Models
{
    public class WholeNatural
    {
        private const int FizzDivider = 3;
        private const int BuzzDivider = 5;
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public WholeNatural(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public static WholeNatural Create(int value)
        {
            return new WholeNatural(value);
        }

        public string ToFizzBuzz()
        {        
            if (Value.IsDivisibleBy(FizzDivider))
                return Fizz;

            if (Value.IsDivisibleBy(BuzzDivider))
                return Buzz;
         
            return Value.ToString();
        }
    }
}
