namespace Calculator
{
    public class SquareRoot
    {
        public static float Eval(float value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value must be non-negative.");
            }
            return (float)Math.Sqrt(value);
        }
    }

}
