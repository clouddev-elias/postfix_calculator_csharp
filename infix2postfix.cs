using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOving
{
    class infix2postfix
    {

        PostfixEvaluator pf = new PostfixEvaluator();
       
        
        
        public bool InfixToPostfixConvert(ref string infixBuffer, out string postfixBuffer)
        {
            int priority = 0;
            postfixBuffer = "";

            Stack<Char> s1 = new Stack<char>();

            for (int i = 0; i < infixBuffer.Length; i++)
            {
                char ch = infixBuffer[i];
                if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
                {
                    // check the precedence
                    if (s1.Count <= 0)
                    {
                        s1.Push(ch); postfixBuffer += " ";
                    }
                    else
                    {
                        if (s1.Peek() == '*' || s1.Peek() == '/')
                            priority = 1;
                        else
                            priority = 0;

                        if (priority == 1)
                        {
                            if (ch == '+' || ch == '-')
                            {
                                postfixBuffer += s1.Pop();
                                i--;
                            }
                            else
                            { // Same
                                postfixBuffer += s1.Pop();
                                i--;
                            }
                        }
                        else
                        {
                            if (ch == '+' || ch == '-')
                            {
                                postfixBuffer += s1.Pop();
                                s1.Push(ch);
                            }
                            else
                                s1.Push(ch);
                                postfixBuffer += " ";
                        }
                    }
                }
                else
                {
                        postfixBuffer += ch;
                }
            }
            int len = s1.Count;
            postfixBuffer += s1.Pop();
            if (s1.Count > 0)
            {
                postfixBuffer += s1.Pop();
                return false;
            }
            else { return true; }
        }


    }
}
