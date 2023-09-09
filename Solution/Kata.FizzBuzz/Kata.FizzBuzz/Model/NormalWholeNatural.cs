namespace Kata.FizzBuzz.Model
{
    public class NormalWholeNatural : WholeNatural
    {
        private NormalWholeNatural() : base()
        {

        }

        private NormalWholeNatural(int number) : base(number)
        {
        }

        public static NormalWholeNatural Create(int number)
        {
            return new NormalWholeNatural(number);
        }

        public static WholeNatural Create()
        {
            return new NormalWholeNatural();
        }

        public override string ToString()
        => Number.ToString();
    }
}
