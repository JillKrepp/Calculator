using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class RPNParser
    {
        
        public decimal CalculateRPN(string rpn)
        {
            string[] rpntokens = rpn.Split(' ');
            Stack<decimal> stack = new Stack<decimal>();
            decimal number = decimal.Zero;
            
            foreach (string token in rpntokens)
            {
                if (decimal.TryParse(token, out number))
                    stack.Push(number);
                else
                {
                    switch (token)
                    {
                        case "+": stack.Push(stack.Pop() + stack.Pop());
                            break;

                        case "-":
                            number = stack.Pop();
                            stack.Push(stack.Pop() - number);
                            break;
                        case "*":
                            stack.Push(stack.Pop() * stack.Pop());
                            break;

                        case "/":
                            number = stack.Pop();
                            stack.Push(stack.Pop() / number);
                            break;
                        default:
                            throw new InvalidOperationException("Unexpected Operators: " + token);
                    }

                }
            }
            return stack.Pop();
        }
    }
}
