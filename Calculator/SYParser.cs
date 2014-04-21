using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class SYParser
    {
        private string expr;

        public SYParser()
        {
            //Prevent a NullPointerException
            setExpr("");
        }
        public SYParser(string expr)
        {
            setExpr(expr);
        }
       
        public void setExpr(string expr)
        {
            this.expr = expr;
        }
        // Return a string output in RPN
        public string getRPN()
        {
            string[] splitExpr = expr.Split(' ');
            Stack<string> valsStk = new Stack<string>();
            Stack<char> symbolStk = new Stack<char>();
            return parse(splitExpr, valsStk, symbolStk);
        }
        public string[] GetTokenizedRPN()
        {
            return getRPN().Split(' ');
        }
        private String parse(string[] tokens, Stack<string> vStk, Stack<char> sStk)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                string token = tokens[i];

                
                switch (token)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        while (!sStk.isEmpty())
                        {
                            if (!sStk.Peek().Equals("("))
                                if (precedence(sStk.Peek()) >= precedence(token[0]))
                                {
                                    vStk.Push(sStk.Pop() + "");
                                }
                                else
                                    break;
                        }
                        sStk.Push(token[0]);
                        break;
                    case "(":
                        sStk.Push(token[0]);
                        break;
                    case ")":
                        while (!sStk.isEmpty())
                        {
                            if (sStk.Peek().Equals('('))
                            {
                                sStk.Pop();
                                break;
                            }
                            vStk.Push(sStk.Pop() + "");
                        }
                        break;
                    default:
                        vStk.Push(token);
                        break;

                }
            }
            while (!sStk.isEmpty())
                vStk.Push(sStk.Pop() + "");

            String result = "";
            while (!vStk.isEmpty())
                result = vStk.Pop() + " " + result;
            return result.Trim();
        }

        private int precedence(char op)
        {
            switch (op)
            {
                case '*':
                    return 5;

                case '/':
                    return 5;

                case '%':
                    return 5;

                case '-':
                    return 4;

                case '+':
                    return 4;
            }
            return 0;
        }
    }
}

