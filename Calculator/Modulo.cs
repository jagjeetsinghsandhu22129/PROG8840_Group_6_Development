namespace Calculator
{
    public class Modulo : IBinaryOperator
    {
        public static float Eval(float lhs, float rhs)
        {
            return lhs % rhs;
        }

    }
}