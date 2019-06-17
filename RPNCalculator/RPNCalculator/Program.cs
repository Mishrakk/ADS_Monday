using System;
using System.Collections.Generic;

namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static double PostFixEvaluator(string Expression)
        {
            Stack<int> stack = new Stack<int>();
            string[] expressionArray = Expression.Split(' ');
            for(int i=0; i< expressionArray.Length; i++)
            {
                if (int.TryParse(expressionArray[i],out int number))
                {

                }
            }

            return 0;

        }

    }
}
