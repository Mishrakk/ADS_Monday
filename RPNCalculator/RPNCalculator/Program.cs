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
                    stack.Push(number);
                   
                }
                else
                {
                    int op2 = stack.Pop();
                    int op1 = stack.Pop();
                    int result = Evaluate(op1, op2, expressionArray[i]);
                    stack.Push(result);
                }
            }

            return stack.Pop();

        }
        public static int Evaluate(int op1 , int op2, string op)
        {
            if (op == "+")
            {
                return op1 + op2;
            }
            else
            {
                return op1 - op2;
            }
        }

    }
}
