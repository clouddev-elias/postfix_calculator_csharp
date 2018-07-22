using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOving
{
    class PostfixEvaluator
    {
        
        public PostfixEvaluator()
        {
        }

        public int EvaluatePostfix(char[] s)
        {
            Stack<int> operand = new Stack<int>();
            Stack<char> operator1 = new Stack<char>();
            Stack<int> Result = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {

                if (isOperator(c))
                {
                    String Tall = sb.ToString();
                    int n;
                    operator1.Push(c);

                    if (int.TryParse(Tall, out n))
                    {

                        n = Convert.ToInt32(Tall);
                        operand.Push(n);
                        sb.Clear();

                    }


                    
                    if (operand.Count >= 2)
                    {
                        Compute(operand, operator1, operand);
                    }
                    
                }
                
                else if (Char.IsNumber(c) || Char.IsWhiteSpace(c))
                {
                    String Tall = sb.ToString();
                    int n;

                    if (Char.IsNumber(c)) {

                        int i = c - '0';
                        sb.Append(i);
                    
                    }

                    else if (Char.IsWhiteSpace(c) && int.TryParse(Tall, out n))
                    {
                       
                        n = Convert.ToInt32(Tall);
                        operand.Push(n);
                        sb.Clear();

                    }

                }

                
             
            }

           if (operand.Count == 2)
                {
                    Compute(operand, operator1, Result);
                }

            return operand.Pop();
        }

        public static void Compute(Stack<int> operand, Stack<char> operator1, Stack<int> result)
        {
            int operand1 = operand.Pop();
            int operand2 = operand.Pop();
            char op = operator1.Pop();

            if (op == '+')
                operand.Push(operand1 + operand2);
            else
                if (op == '-')
                   operand.Push(operand2 - operand1);
                else
                    if (op == '*')
                        operand.Push(operand1 * operand2);
                    else
                        if (op == '/')
                            operand.Push(operand2 / operand1);
        }


        public static bool isOperator(char c)
        {
            bool result = false;
            if (c == '+' || c == '-' || c == '*' || c == '/')
                result = true;
            return result;
        }

    }
}
