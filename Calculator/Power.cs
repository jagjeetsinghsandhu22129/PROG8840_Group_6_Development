namespace Calculator
{
  
        public class Power : IBinaryOperator
        {
            public static float Eval(float lhs, float rhs)
            {
                return (float)System.Math.Pow(lhs, rhs);
            }
        }
}


